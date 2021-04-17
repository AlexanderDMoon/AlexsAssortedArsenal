using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Penumbrite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Penumbrite");
            Tooltip.SetDefault("A dark, heavy gem that glitters in the light. It almost looks like a chunk of the night sky.");
        }

        public override void SetDefaults()
        {
            item.width = 14;
            item.height = 18;
            item.value = Item.sellPrice(0, 0, 9, 0);
            item.maxStack = 999;
            item.rare = 0;
        }
	}
}