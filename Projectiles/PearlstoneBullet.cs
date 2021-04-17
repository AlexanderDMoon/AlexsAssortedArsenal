using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class PearlstoneBullet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pearlstone Bullet");
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
            {
                if (target.type == NPCID.BigCrimslime ||
                  target.type == NPCID.LittleCrimslime ||
                  target.type == NPCID.BigCrimera ||
                  target.type == NPCID.LittleCrimera ||
                  target.type == NPCID.BigEater ||
                  target.type == NPCID.LittleEater ||
                  target.type == NPCID.Slimer2 ||
                  target.type == NPCID.Slimeling ||
                  target.type == NPCID.EaterofSouls ||
                  target.type == NPCID.DevourerHead ||
                  target.type == NPCID.DevourerBody ||
                  target.type == NPCID.DevourerTail ||
                  target.type == NPCID.EaterofWorldsHead ||
                  target.type == NPCID.EaterofWorldsBody ||
                  target.type == NPCID.EaterofWorldsTail ||
                  target.type == NPCID.CorruptBunny ||
                  target.type == NPCID.CorruptGoldfish ||
                  target.type == NPCID.DarkMummy ||
                  target.type == NPCID.CorruptSlime ||
                  target.type == NPCID.CursedHammer ||
                  target.type == NPCID.Corruptor ||
                  target.type == NPCID.SeekerHead ||
                  target.type == NPCID.SeekerBody ||
                  target.type == NPCID.SeekerTail ||
                  target.type == NPCID.Clinger ||
                  target.type == NPCID.Slimer ||
                  target.type == NPCID.PigronCorruption ||
                  target.type == NPCID.Crimera ||
                  target.type == NPCID.Herpling ||
                  target.type == NPCID.CrimsonAxe ||
                  target.type == NPCID.PigronCrimson ||
                  target.type == NPCID.FaceMonster ||
                  target.type == NPCID.FloatyGross ||
                  target.type == NPCID.Crimslime ||
                  target.type == NPCID.BloodCrawler ||
                  target.type == NPCID.BloodCrawlerWall ||
                  target.type == NPCID.BloodFeeder ||
                  target.type == NPCID.BloodJelly ||
                  target.type == NPCID.BrainofCthulhu ||
                  target.type == NPCID.Creeper ||
                  target.type == NPCID.IchorSticker ||
                  target.type == NPCID.BigMimicCrimson ||
                  target.type == NPCID.BigMimicCorruption) ;
            }
            damage = (int)(damage * 1.50f);
        }


        public override bool PreAI()
        {
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