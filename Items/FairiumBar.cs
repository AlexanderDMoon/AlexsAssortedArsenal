using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FairiumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Steel Bar");
            Tooltip.SetDefault("An ingot of enchanted metal.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.rare = 6;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Iron or Lead Bar", 2);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}