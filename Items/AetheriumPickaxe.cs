using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AetheriumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aetherium Pickaxe");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 88;
            item.melee = true;
			item.width = 52;
			item.height = 52;
			item.useTime = 3;
			item.useAnimation = 11;
            item.pick = 250;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Lunar Pickaxe", 1);
            recipe.AddIngredient(mod, "AetheriumBar", 8);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}