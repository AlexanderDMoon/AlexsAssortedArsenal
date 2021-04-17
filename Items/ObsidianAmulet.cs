using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class ObsidianAmulet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obsidian Amulet");
            Tooltip.SetDefault("Grants one additional Minion slot. \nIncreases movement speed by 5%.");
		}

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 30;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.maxMinions += 1;
            player.moveSpeed += 0.05f;
        }
	}
}