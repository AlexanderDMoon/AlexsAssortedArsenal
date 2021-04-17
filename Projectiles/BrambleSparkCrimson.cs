using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class BrambleSparkCrimson : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crimson Bramble Burst");
        }

        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 120;
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
                Main.PlaySound(SoundID.Item10, projectile.position);
            }
            return true;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            return (this.DrawProjectileCentered(spriteBatch, lightColor));
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)//
        {
            if (projectile.timeLeft > 3)
            {
                projectile.timeLeft = 3;
            }
        }
        public override void OnHitPvp(Player target, int damage, bool crit)//
        {
            if (projectile.timeLeft > 3)
            {
                projectile.timeLeft = 3;
            }
        }

        public override void Kill(int timeLeft)
        {
            SpawnProjectilePatternOn(projectile, ModContent.ProjectileType<BrambleSparkCrimsonFragment>(), 2, projectile.rotation + MathHelper.PiOver2, MathHelper.Pi, 8f);

            for (int i = 0; i < 30; ++i)
            {
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 100, default, 1f)];
                newDust.velocity *= 1.4f;
            }

            for (int i = 0; i < 20; ++i)
            {
                Dust newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 100, default, 1f)];
                newDust.noGravity = true;
                newDust.velocity *= 7f;

                newDust = Main.dust[Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 100, default, 1f)];
                newDust.velocity *= 3f;
            }

            Main.PlaySound(SoundID.Item118, projectile.position);
        }

        public void SpawnProjectilePatternOn(Projectile proj, int type, int amount, float startRot, float rotInterval, float speed)
        {

            // Don't spawn the subprojectiles if this multiplayer instance is not the owner of the projectile.
            if (Main.myPlayer != proj.owner)
            {
                return;
            }

            // Loop for the amount of projectiles we want to spawn.
            for (int i = 0; i < amount; ++i)
            {
                Vector2 newVelocity = (startRot + rotInterval * i).ToRotationVector2() * speed;

                Projectile.NewProjectile(proj.Center, newVelocity, type, projectile.damage, projectile.knockBack, proj.owner);
            }
        }

        public override bool PreAI()
        {
            projectile.velocity *= 0.98f;
            projectile.rotation += projectile.velocity.Length() * 0.02f * projectile.direction;
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 60, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }

            return (false);
        }

        public override void PostAI()//
        {
            if (projectile.timeLeft <= 3)
            {
                projectile.position = projectile.Center;
                projectile.width = projectile.height = 100;
                projectile.Center = projectile.position;
            }
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}