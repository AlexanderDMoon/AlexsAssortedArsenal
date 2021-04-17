using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MoltenCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Charm");
            Tooltip.SetDefault("All attacks light enemies on fire. \nIncreases damage by 6%");
		}

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 26;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.06f;
            player.GetModPlayer<AAAModPlayer>().MoltenCharmEffect = true;
        }
	}
}