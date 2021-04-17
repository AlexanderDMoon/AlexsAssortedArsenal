using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class BunnyPelt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Pelt");
            Tooltip.SetDefault("The soft pelt of an innocent creature. \n'Bnuuy'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 0, 5);
            item.maxStack = 999;
            item.rare = 0;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Bunny)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("BunnyPelt"), Main.rand.Next(1, 3));
                }
            }
        }
    }
}