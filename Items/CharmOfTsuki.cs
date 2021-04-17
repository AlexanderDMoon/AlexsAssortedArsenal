using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CharmOfTsuki : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Charm of Tsuki");
            Tooltip.SetDefault("Increases magic and minion damage by 16%. \nMagic and Minion damage inflicts Frostburn for 5 seconds. \n'Once held by an ancient Cryomancer, this coin embues the holder with frigid power.'");
		}

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 7, 25, 0);
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magicDamage += 0.16f;
            player.minionDamage += 0.16f;
            player.GetModPlayer<AAAModPlayer>().CharmOfTsukiEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PeacekeeperEmblem", 1);
            recipe.AddIngredient(mod, "SoulofChills", 8);
            recipe.AddIngredient(ItemID.DarkShard, 2);
            recipe.AddIngredient(ItemID.MoonStone, 1);
            recipe.AddTile(mod, "PeacekeeperAnvil");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}