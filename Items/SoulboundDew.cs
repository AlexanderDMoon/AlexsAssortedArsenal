using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SoulboundDew : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soulbound Dew");
            Tooltip.SetDefault("A drop of dew, infused with the souls of those before us.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.width = 28;
            item.height = 28;
            item.maxStack = 1;
            item.rare = -12;
            item.expert = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Plantera)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("SoulboundDew"), 1);
                }
            }
        }
    }
}