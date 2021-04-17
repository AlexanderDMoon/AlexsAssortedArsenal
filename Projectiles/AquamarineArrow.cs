using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Projectiles
{
    public class AquamarineArrow : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquamarine Arrow");
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
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.extraUpdates = 0;
            aiType = ProjectileID.WoodenArrowFriendly;
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

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
        {
            width = height = 10;
            return true;
        }
    }
}