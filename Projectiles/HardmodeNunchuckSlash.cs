using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class HardmodeNunchuckSlash : ModProjectile //Special thanks to DayOrk for making this code for me!
    {
        public float Alpha = 1f;
        public override void SetDefaults()
        {
            projectile.width = 42;
            projectile.height = 42;
            projectile.friendly = true;
            projectile.tileCollide = false;
            projectile.melee = true;
            projectile.alpha = 60;
            projectile.penetrate = -1;
            projectile.ownerHitCheck = true;
            projectile.alpha = 255;

            projectile.timeLeft = 10;
            Main.projFrames[projectile.type] = 8;
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (Main.rand.Next(7) == 0)
            {
                target.AddBuff(BuffID.Confused, 450);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.immune[projectile.owner] = 18;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hardmode Nunchuck Slash");
        }

        public override bool PreAI()
        {
            Player p = Main.player[projectile.owner];
            if(++projectile.frameCounter >= p.HeldItem.useAnimation / 8)
            {
                if (++projectile.frame > 8)
                    projectile.frame = 0;
                projectile.frameCounter = 0;
            }
            if (p.channel)
            {
                projectile.velocity = (Main.MouseWorld - p.Center).SafeNormalize(-Vector2.UnitY) * 16f;
                projectile.Center = p.Center + (Main.MouseWorld - p.Center).SafeNormalize(-Vector2.UnitY) * 16f;
                int dir = projectile.direction;
                projectile.timeLeft = 18;
                p.ChangeDir(dir);
                p.itemAnimation = 2;
                p.itemTime = 18;
                p.itemRotation = (float)Math.Atan2(projectile.velocity.Y * dir, projectile.velocity.X * dir);
                p.heldProj = projectile.whoAmI;
            }
            else
            {
                Alpha = 0f;
                projectile.Kill();
            }

            return true;
        }

        public override void PostDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Player p = Main.player[projectile.owner];
            var Texture = ModContent.GetTexture("AlexsAssortedArsenal/Projectiles/HardmodeNunchuckSlash");
            spriteBatch.Draw(
                Texture,
                p.Center + (Main.MouseWorld - p.Center).SafeNormalize(-Vector2.UnitY) * 14f - Main.screenPosition,
                new Rectangle(0, Texture.Height / 8 * projectile.frame, Texture.Width, Texture.Height / 8),
                Color.White * Alpha,
                projectile.velocity.ToRotation() + .20f,
                new Vector2(Texture.Width / 2, Texture.Height / 8 / 2),
                1f,
                SpriteEffects.None,
                1
                );
        }
    }
}