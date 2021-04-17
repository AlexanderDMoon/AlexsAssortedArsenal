using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AncientCoins : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Coins");
            Tooltip.SetDefault("A handful of old coins with a blue X-shaped emblem. Most seem ruined beyond use." +
                                "\nYou have no idea what to do with these. Maybe you should wait for someone who can work with it?");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.width = 30;
            item.height = 22;
            item.maxStack = 1;
            item.rare = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.EyeofCthulhu)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("AncientCoins"), 1);
                }
            }
        }
    }
}