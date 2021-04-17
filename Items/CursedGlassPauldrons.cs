using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CursedGlassPauldrons : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pauldrons of Cursed Glass");
            Tooltip.SetDefault("Increases damage dealt by 500%. \nIncreases damage taken by 425%. \nIncreases enemy spawnrates.");
		}

        public override void SetDefaults()
        {
            item.width = 62;
            item.height = 36;
            item.value = Item.sellPrice(1, 75, 0, 0);
            item.rare = 9;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 5f;
            player.GetModPlayer<AAAModPlayer>().CursedGlassPauldronsEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CursedGlassCube", 1);
            recipe.AddIngredient(ItemID.LunarBar, 15);
            recipe.AddIngredient(ItemID.FragmentSolar, 25);
            recipe.AddIngredient(ItemID.FragmentNebula, 25);
            recipe.AddIngredient(ItemID.FragmentVortex, 25);
            recipe.AddIngredient(ItemID.FragmentStardust, 25);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}