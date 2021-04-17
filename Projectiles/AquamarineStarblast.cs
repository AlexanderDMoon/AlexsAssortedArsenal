using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class AquamarineStarblast : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquamarine Starblast");
        }

        public override void SetDefaults()
        {
            aiType = ProjectileID.Bullet;
            projectile.width = 4;
            projectile.height = 4;
            projectile.aiStyle = 1;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 600;
            projectile.alpha = 255;
            projectile.ignoreWater = false;
            projectile.tileCollide = true;
            projectile.extraUpdates = 1;
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

        public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            List<int> listName = new List<int>()
            {
                NPCID.MeteorHead,
                NPCID.FireImp,
                NPCID.BurningSphere,
                NPCID.BoneSerpentHead,
                NPCID.BoneSerpentBody,
                NPCID.BoneSerpentTail,
                NPCID.LavaSlime,
                NPCID.Hellbat,
                NPCID.Demon,
                NPCID.VoodooDemon,
                NPCID.WallofFlesh,
                NPCID.WallofFleshEye,
                NPCID.TheHungry,
                NPCID.TheHungryII,
                NPCID.LeechHead,
                NPCID.LeechBody,
                NPCID.LeechTail,
                NPCID.Lavabat,
                NPCID.RedDevil,
                NPCID.HellArmoredBones,
                NPCID.HellArmoredBonesSpikeShield,
                NPCID.HellArmoredBonesMace,
                NPCID.HellArmoredBonesSword,
                NPCID.DiabolistRed,
                NPCID.DiabolistWhite,
                NPCID.MourningWood,
                NPCID.Pumpking,
                NPCID.Hellhound,
                NPCID.SolarCrawltipedeTail,
                NPCID.SolarDrakomire,
                NPCID.SolarDrakomireRider,
                NPCID.SolarSroller,
                NPCID.SolarCorite,
                NPCID.SolarSolenian,
                NPCID.GoblinSummoner,
                NPCID.ShadowFlameApparition,
                NPCID.LunarTowerSolar,
                NPCID.SolarSpearman,
                NPCID.DD2Betsy,
            };
            if (listName.Contains(target.type))
                damage = (int)(damage * 1.20f);
        }

        public override bool PreAI()
        {
            projectile.velocity.Y += projectile.ai[0];
            {
                Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 59, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
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