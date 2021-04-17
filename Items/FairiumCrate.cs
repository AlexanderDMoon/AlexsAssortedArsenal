using AlexsAssortedArsenal.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FairiumCrate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Crate");
            Tooltip.SetDefault("Contains a handful of Fairium Steel Ingots. \nRight-click to open.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.width = 34;
            item.height = 44;
            item.maxStack = 999;
            item.rare = 6;
        }

        public override void RightClick(Player player)
        {
            item.stack--;
            int choice = Main.rand.Next(1);
            if (choice == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<FairiumBar>(), Main.rand.Next(12, 17));
            }
        }

        public override bool CanRightClick()
        {
            return true;
        }
    }
}
