using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Shard");
            Tooltip.SetDefault("A shard of dark purple crystal. It lets out a constant, low hum.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 12;
            item.value = Item.sellPrice(0, 0, 0, 12);
            item.maxStack = 999;
            item.rare = 4;
        }
	}
}