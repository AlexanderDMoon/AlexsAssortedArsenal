using System;
using AlexsAssortedArsenal.Projectiles.Minions;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Projectiles.Minions
{
	public abstract class HoverAttacker : AAAMinionAI
	{
		protected int shoot;
		protected float shootSpeed;
		protected float shootCool = 90f;
		public virtual void CreateDust()
		{

		}

        public override void Behavior()
		{
			Player player = Main.player[projectile.owner];

            #region Targetting
            Vector2 targetPos = projectile.position;
			float targetDist = 400f;
			bool target = false;
			if (player.HasMinionAttackTargetNPC)
			{
				//Right-click Targetting
				NPC npc = Main.npc[player.MinionAttackTargetNPC];
				if (Collision.CanHitLine(projectile.position, projectile.width, projectile.height, npc.position, npc.width, npc.height))
				{
					targetPos = npc.Center;
					targetDist = Vector2.Distance(projectile.Center, targetPos);
					target = true;
				}
			}
			else
			{
				//Find targetable NPC, assign position and distance
				for (int k = 0; k < 200; k++)
				{
					NPC npc = Main.npc[k];
					if (npc.CanBeChasedBy(this, false))
					{
						float distance = Vector2.Distance(npc.Center, projectile.Center);
						if ((distance < targetDist || !target) && Collision.CanHitLine(projectile.position, projectile.width, projectile.height, npc.position, npc.width, npc.height))
						{
							targetDist = distance;
							targetPos = npc.Center;
							target = true;
						}
					}
				}
			}
			#endregion

			#region Movement
			//Idling Position
			Vector2 idlePosition = player.Center;
			idlePosition.Y -= 48f; //16f = 1 tile
			Vector2 vectorToIdlePosition = idlePosition - projectile.Center;
			float distanceToIdlePosition = vectorToIdlePosition.Length();

			
			//Movement Toward Target
			float chaseDist = 200f;
			float chaseAccel = 6f;
			float inertia = 40f;
			if (target && projectile.ai[0] == 0f)
			{
				Vector2 direction = targetPos - projectile.Center;
				if (direction.Length() > chaseDist)
				{
					direction.Normalize();
					projectile.tileCollide = true;
					projectile.velocity = (projectile.velocity * inertia + direction * chaseAccel) / (inertia + 1);
				}
				else
				{
					projectile.velocity *= (float)Math.Pow(0.97, 40.0 / inertia);
				}
			}
			else 
			{
				float speed;
				if (Main.myPlayer == player.whoAmI && distanceToIdlePosition > 2000f)
				{
					//Teleport to owner player if too far
					projectile.position = idlePosition;
					projectile.velocity *= 0.1f;
					projectile.netUpdate = true;
				}

				
				if (distanceToIdlePosition > 600f)
				{
					// Speed up the minion if it's away from the player
					speed = 32f;
					inertia = 60f;
					projectile.tileCollide = false;
				}
				else
				{
					// Slow down the minion if closer to the player
					speed = 16f;
					inertia = 80f;
					projectile.tileCollide = true;
				}
				if (distanceToIdlePosition > 25f)
				{
					vectorToIdlePosition.Normalize();
					vectorToIdlePosition *= speed;
					projectile.velocity = (projectile.velocity * (inertia - 1) + vectorToIdlePosition) / inertia;
				}
				else if (projectile.velocity == Vector2.Zero)
				{
					//Gives projectile a nudge if it happens to stand completely still
					projectile.velocity.X = -0.15f;
					projectile.velocity.Y = -0.05f;
				}
			}

			float overlapVelocity = 0.05f;
			for (int i = 0; i < Main.maxProjectiles; i++)
			{
				{
                    // Fix overlap with other minions
                    Projectile other = Main.projectile[i];
					if (i != projectile.whoAmI && other.active && other.owner == projectile.owner && Math.Abs(projectile.position.X - other.position.X) + Math.Abs(projectile.position.Y - other.position.Y) < projectile.width)
					{
						if (projectile.position.X < other.position.X)
							projectile.velocity.X -= overlapVelocity;
						else
							projectile.velocity.X += overlapVelocity;

						if (projectile.position.Y < other.position.Y)
							projectile.velocity.Y -= overlapVelocity;
						else
							projectile.velocity.Y += overlapVelocity;
					}
				}
			}
            
            if (++projectile.frameCounter >= 2)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 2)
                {
                    projectile.frame = 0;
                }
            }

            //Projectile will slightly lean towards the direction it is moving towards
            projectile.rotation = projectile.velocity.X * 0.05f;
            projectile.spriteDirection = projectile.direction;
            #endregion

            CreateDust();

			#region Firing
			//Firing Cooldown
			if (projectile.ai[1] > 0f)
			{
				//Time ticking until next shot
				projectile.ai[1] += 1f;
				if (Main.rand.NextBool(3))
				{
					projectile.ai[1] += 1f;
				}
			}
			if (projectile.ai[1] > shootCool)
			{
				//Ready to fire again
				projectile.ai[1] = 0f;
				projectile.netUpdate = true;
			}

			//Fires projectile at target
			if (projectile.ai[0] == 0f)
			{
				if (target)
				{
					//Ensure proper sprite direction
					if ((targetPos - projectile.Center).X > 0f)
					{
						projectile.spriteDirection = projectile.direction = 1;
					}
					else if ((targetPos - projectile.Center).X < 0f)
					{
						projectile.spriteDirection = projectile.direction = -1;
					}
					if (projectile.ai[1] == 0f)
					{
						projectile.ai[1] = 1f;
						if (Main.myPlayer == projectile.owner)
						{
							Vector2 shootVel = targetPos - projectile.Center;
							if (shootVel == Vector2.Zero)
							{
								shootVel = new Vector2(0f, 1f);
							}
							shootVel.Normalize();
							shootVel *= shootSpeed;
							int proj = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, shootVel.X, shootVel.Y, shoot, projectile.damage, projectile.knockBack, Main.myPlayer, 0f, 0f);
							Main.projectile[proj].timeLeft = 300;
							Main.projectile[proj].netUpdate = true;
							projectile.netUpdate = true;
						}
					}
				}
			}
			#endregion
		} //end Behavior
	}
	//end Class
}
