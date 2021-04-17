using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class ExecutionersBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Executioner's Greatsword");
            Tooltip.SetDefault("Enemies above 50% HP take 15% more damage. \nNon-boss enemies below 25% HP have a chance to be instantly killed. \n'When I raise this blade, so I wish this poor sinner receive eternal life.' \nLegendary Weapon");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 125;
            item.useTime = 23;
            item.useAnimation = 23;
            item.width = 70;
            item.height = 70;
            item.knockBack = 4;
            item.value = Item.sellPrice(2, 0, 0, 0);
            item.rare = -12;
            item.autoReuse = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.crit = 4;
            item.expert = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (target.life < target.lifeMax / 2f && !target.boss)
            {
                damage = (int)(damage * 1.15f);
            }

            else if (target.life < target.lifeMax / 4f && target.CanBeChasedBy())
            {
                target.life = 0;
                target.HitEffect(0, 10.0);
                target.active = false;
            }
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Golem)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("ExecutionersBlade"), 1);
                }
            }
        }
    }
}
