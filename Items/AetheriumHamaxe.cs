using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AetheriumHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aetherium Hamaxe");
		}

		public override void SetDefaults()
		{
			item.damage = 67;
            item.melee = true;
			item.width = 48;
			item.height = 42;
			item.useTime = 6;
			item.useAnimation = 18;
            item.axe = 35;
            item.hammer = 125;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Lunar Hamaxe", 1);
            recipe.AddIngredient(mod, "AetheriumBar", 8);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}