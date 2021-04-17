using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Aquamarine : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine");
            Tooltip.SetDefault("A light, smooth gem. It shines like the ocean.");
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