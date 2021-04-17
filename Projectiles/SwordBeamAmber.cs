using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class SwordBeamAmber : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Sword Beam");
        }

        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.width = 12;
            projectile.height = 12;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.melee = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.penetrate--;
            if (projectile.penetrate <= 0)
            {
                Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
                Main.PlaySound(SoundID.Dig, projectile.position);
            }
            return true;
        }

        public override bool PreAI()
        {
            projectile.velocity.Y += projectile.ai[0];
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 158, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }

            return true;
        }

        public override void PostAI()
        {
            if (projectile.timeLeft <= 3)
            {
                projectile.position = projectile.Center;
                projectile.width = projectile.height = 60;
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
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 158, 0f, 0f, 100, default, 1f)];
                newDust.velocity *= 1.4f;
            }

            for (int i = 0; i < 20; ++i)
            {
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 158, 0f, 0f, 100, default, 1f)];
                newDust.noGravity = true;
                newDust.velocity *= 7f;

                newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 158, 0f, 0f, 100, default, 1f)];
                newDust.velocity *= 3f;
            }

            Main.PlaySound(SoundID.Item118, projectile.position);
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}