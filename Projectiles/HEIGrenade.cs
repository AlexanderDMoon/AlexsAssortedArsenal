using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class HEIGrenade : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("H.E.I. Grenade");
        }

        public override void SetDefaults()
        {
            projectile.damage = 80;
            projectile.width = 4;
            projectile.height = 14;
            projectile.aiStyle = 16;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.ranged = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 180;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 0;
            aiType = ProjectileID.Grenade;
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.Next(3) == 0)
            {
                target.AddBuff(mod.BuffType("Slashed"), 60);
            }
        }

        public override void PostAI()
        {
            if (projectile.timeLeft <= 3)
            {
                projectile.position = projectile.Center;
                projectile.width = projectile.height = 80;
                projectile.Center = projectile.position;
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.timeLeft > 3)
            {
                projectile.timeLeft = 3;
            }
        }
        public override void OnHitPvp(Player target, int damage, bool crit)
        {
            if (projectile.timeLeft > 3)
            {
                projectile.timeLeft = 3;
            }
        }

        public override void Kill(int timeLeft)
        {
            // Positioning stuff...

            for (int i = 0; i < 30; ++i)
            {
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 31, 0f, 0f, 100, default, 1.5f)];
                newDust.velocity *= 1.4f;
            }

            for (int i = 0; i < 20; ++i)
            {
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 100, default, 3.5f)];
                newDust.noGravity = true;
                newDust.velocity *= 7f;

                newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 100, default, 1.5f)];
                newDust.velocity *= 3f;
            }

            for (int i = 0; i < 2; ++i)
            {
                float num729 = i == 1 ? 0.8f : 0.4f;

                Gore newGore = Main.gore[Gore.NewGore(projectile.position, default, Main.rand.Next(61, 64))];
                newGore.velocity *= num729;
                newGore.velocity += Vector2.One;

                newGore = Main.gore[Gore.NewGore(projectile.position, default, Main.rand.Next(61, 64))];
                newGore.velocity *= num729;
                newGore.velocity.X -= 1f;
                newGore.velocity.Y += 1f;

                newGore = Main.gore[Gore.NewGore(projectile.position, default, Main.rand.Next(61, 64))];
                newGore.velocity *= num729;
                newGore.velocity.X += 1f;
                newGore.velocity.Y -= 1f;

                newGore = Main.gore[Gore.NewGore(projectile.position, default, Main.rand.Next(61, 64))];
                newGore.velocity *= num729;
                newGore.velocity -= Vector2.One;
            }

            Main.PlaySound(SoundID.Item62, projectile.position);
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}