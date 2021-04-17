using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class PurityBeam : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purity Beam");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.penetrate = 1;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 4;
            aiType = ProjectileID.BulletHighVelocity;
        }

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            List<int> listName = new List<int>()
            {
                NPCID.ChaosElemental,
                NPCID.Gastropod,
                NPCID.BigMimicHallow,
                NPCID.IlluminantBat,
                NPCID.Unicorn,
                NPCID.PigronHallow,
                NPCID.IlluminantSlime,
                NPCID.EnchantedSword,
                NPCID.LightMummy,
                NPCID.RainbowSlime,
                NPCID.BigCrimslime,
                NPCID.LittleCrimslime,
                NPCID.BigCrimera,
                NPCID.LittleCrimera,
                NPCID.BigEater,
                NPCID.LittleEater,
                NPCID.Slimer2,
                NPCID.Slimeling,
                NPCID.EaterofSouls,
                NPCID.DevourerHead,
                NPCID.DevourerBody,
                NPCID.DevourerTail,
                NPCID.EaterofWorldsHead,
                NPCID.EaterofWorldsBody,
                NPCID.EaterofWorldsTail,
                NPCID.CorruptBunny,
                NPCID.CorruptGoldfish,
                NPCID.DarkMummy,
                NPCID.CorruptSlime,
                NPCID.CursedHammer,
                NPCID.Corruptor,
                NPCID.SeekerHead,
                NPCID.SeekerBody,
                NPCID.SeekerTail,
                NPCID.Clinger,
                NPCID.Slimer,
                NPCID.PigronCorruption,
                NPCID.Crimera,
                NPCID.Herpling,
                NPCID.CrimsonAxe,
                NPCID.PigronCrimson,
                NPCID.FaceMonster,
                NPCID.FloatyGross,
                NPCID.Crimslime,
                NPCID.BloodCrawler,
                NPCID.BloodCrawlerWall,
                NPCID.BloodFeeder,
                NPCID.BloodJelly,
                NPCID.BrainofCthulhu,
                NPCID.Creeper,
                NPCID.IchorSticker,
                NPCID.BigMimicCrimson,
                NPCID.BigMimicCorruption,
            };
            if (listName.Contains(target.type))
            damage = (int)(damage * 2.00f);
        }

        public override bool PreAI()
        {
            projectile.velocity.Y += projectile.ai[0];
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 63, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
            }

            if (projectile.timeLeft <= 575)
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