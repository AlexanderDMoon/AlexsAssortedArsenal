using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class GunpowderCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gunpowder Core");
            Tooltip.SetDefault("An amorphous core of dense, explosive gelatin.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 18;
            item.value = Item.sellPrice(0, 0, 0, 12);
            item.maxStack = 999;
            item.rare = 1;
        }
	}
}