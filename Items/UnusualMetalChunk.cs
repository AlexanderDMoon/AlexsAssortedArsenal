using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class UnusualMetalChunk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unusual Metal Chunk");
            Tooltip.SetDefault("A hunk of some sort of strange, posessed metal. It shakes and vibrates in your hands, as if it's resisting your grip.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 22;
            item.value = Item.sellPrice(0, 0, 0, 12);
            item.maxStack = 999;
            item.rare = 1;
        }
	}
}