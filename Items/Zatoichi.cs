using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Zatoichi : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zatoichi");
            Tooltip.SetDefault("Right-click to preform a damaging dash.\nEnemies killed by the dash have a chance to drop a heart. \n'Measure twice, cut once.' \nLegendary Weapon");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 12;
            item.width = 62;
            item.height = 60;
            item.useTime = 18;
            item.useAnimation = 18;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = -12;
            item.autoReuse = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.crit = 4;
            item.expert = true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {

            }
            return base.CanUseItem(player);
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.KingSlime)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("Zatoichi"), 1);
                }
            }
        }
    }
}
