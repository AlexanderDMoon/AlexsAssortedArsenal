using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class CoilgunExplosiveBolt : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Coilgun Explosive Bolt");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.ranged = true;
            projectile.penetrate = -1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 5;
            aiType = ProjectileID.BulletHighVelocity;
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