using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal
{
    public class AAAModPlayer : ModPlayer
    {
        public bool CharmOfNamiEffect;
        public bool CharmOfTsukiEffect;
        public bool SigilofCircadiaEffect;
        public bool CursedGlassShardEffect;
        public bool CursedGlassCubeEffect;
        public bool CursedGlassPauldronsEffect;
        public bool MoltenCharmEffect;
        public bool BandofBloodlettingEffect;


        public override void ResetEffects()
        {
            CharmOfNamiEffect = false;
            CharmOfTsukiEffect = false;
            SigilofCircadiaEffect = false;
            CursedGlassShardEffect = false;
            CursedGlassCubeEffect = false;
            CursedGlassPauldronsEffect = false;
            MoltenCharmEffect = false;
            BandofBloodlettingEffect = false;
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (CharmOfNamiEffect)
            {
                target.AddBuff(BuffID.OnFire, 600);
            }

            if (SigilofCircadiaEffect)
            {
                target.AddBuff(BuffID.ShadowFlame, 450);
                target.AddBuff(mod.BuffType("CircadianFury"), 450);
            }

            if (MoltenCharmEffect)
            {
                target.AddBuff(BuffID.OnFire, 120);
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if (CharmOfNamiEffect && (proj.melee || proj.minion || ProjectileID.Sets.MinionShot[proj.type]) && !proj.noEnchantments)
            {
                target.AddBuff(BuffID.OnFire, 600);
            }

            if (CharmOfTsukiEffect && (proj.magic || proj.minion || ProjectileID.Sets.MinionShot[proj.type]) && !proj.noEnchantments)
            {
                target.AddBuff(BuffID.Frostburn, 300);
            }

            if (SigilofCircadiaEffect && (proj.minion || proj.magic || proj.ranged || proj.melee || ProjectileID.Sets.MinionShot[proj.type]) && !proj.noEnchantments)
            {
                target.AddBuff(BuffID.ShadowFlame, 450);
                target.AddBuff(mod.BuffType("CircadianFury"), 450);
            }

            if (MoltenCharmEffect && (proj.minion || proj.magic || proj.ranged || proj.melee || ProjectileID.Sets.MinionShot[proj.type]) && !proj.noEnchantments)
            {
                target.AddBuff(BuffID.OnFire, 120);
            }
        }

        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            if (CursedGlassShardEffect)
            {
                damage = (int)(damage * 2.25f);
                player.enemySpawns = true;
            }

            if (CursedGlassCubeEffect)
            {
                damage = (int)(damage * 4.25f);
                player.enemySpawns = true;
            }

            if (CursedGlassPauldronsEffect)
            {
                damage = (int)(damage * 5.25);
                player.enemySpawns = true;
            }
        }

        public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
        {
            if (BandofBloodlettingEffect)
            {
                player.AddBuff(mod.BuffType("Bloodletting"), 10);
            }
        }

        public Vector2 lastDeathPos;
        public override void Kill(double damage, int hitDirection, bool pvp, PlayerDeathReason damageSource)
        {
            lastDeathPos = player.position;
        }
        public override TagCompound Save()
        {
            TagCompound tag = new TagCompound()
            {
        {
                    nameof(lastDeathPos), lastDeathPos }
            };
            return (tag);
        }
        public override void Load(TagCompound tag)
        {
            lastDeathPos = tag.Get<Vector2>(nameof(lastDeathPos));
        }

        //public override void ProcessTriggers(TriggersSet triggersSet)
        //{
        //    if (triggersSet.QuickHeal)
        //    {
        //        if (player.HasItem(mod.ItemType("HealingPotionMelee")));
        //    }
        //}
    }
}