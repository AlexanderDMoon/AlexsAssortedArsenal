using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class EnchantedSilverShot : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted SilverShot");
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
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
            aiType = ProjectileID.Bullet;
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

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            List<int> listName = new List<int>()
            {
                NPCID.Werewolf,
                NPCID.CorruptBunny,
                NPCID.CorruptGoldfish,
                NPCID.Wraith,
                NPCID.Clown,
                NPCID.VampireBat,
                NPCID.Vampire,
                NPCID.Frankenstein,
                NPCID.SwampThing,
                NPCID.LostGirl,
                NPCID.Nymph,
                NPCID.Eyezor,
                NPCID.Reaper,
                NPCID.Raven,
                NPCID.ChatteringTeethBomb,
                NPCID.Butcher,
                NPCID.CreatureFromTheDeep,
                NPCID.Fritz,
                NPCID.Nailhead,
                NPCID.CrimsonBunny,
                NPCID.CrimsonGoldfish,
                NPCID.Psycho,
                NPCID.DeadlySphere,
                NPCID.DrManFly,
                NPCID.ThePossessed,
                NPCID.CrimsonPenguin,
                NPCID.Mothron,
                NPCID.MothronSpawn,
                NPCID.MothronEgg,
                NPCID.Medusa ,
                NPCID.BloodZombie,
                NPCID.Drippler,
                NPCID.DesertLamiaLight,
                NPCID.DesertLamiaDark,
                NPCID.DesertGhoul,
                NPCID.DesertGhoulCorruption,
                NPCID.DesertGhoulCrimson,
                NPCID.DesertGhoulHallow,
                NPCID.DesertBeast,
                NPCID.DesertDjinn
            };
            if (listName.Contains(target.type))
                damage = (int)(damage * 1.25f);
        }

        public override bool PreAI()
        {
            projectile.velocity.Y += projectile.ai[0];
            {
                //Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }
            projectile.rotation =
                    projectile.velocity.ToRotation() +
                    MathHelper.ToRadians(90f);

            return true;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
        {
            Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
            for (int k = 0; k < projectile.oldPos.Length; k++)
            {
                Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);  
                Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
                spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
            }
            return true;
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}