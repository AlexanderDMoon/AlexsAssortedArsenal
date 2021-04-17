using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Datapad : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blank Datapad");
            Tooltip.SetDefault("An old, somehow operational datapad left by some unknown people. \nMaybe it'll attract the attention of someone who knows about this kind of thing?");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 30;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.maxStack = 1;
            item.rare = 3;
        }
	}
}