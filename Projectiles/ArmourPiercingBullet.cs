using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class ArmourPiercingBullet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Armour Piercing Bullet");
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
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 5;
            aiType = ProjectileID.BulletHighVelocity;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            projectile.penetrate--;
            if (projectile.penetrate >= 0)
            {
                Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
                Main.PlaySound(SoundID.Dig, projectile.position);
            }
            return true;
        }

        public override bool PreAI()
        {
            if (projectile.timeLeft <= 588)
                projectile.alpha = 0;
            else
                projectile.alpha = 255;

            return true;
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}