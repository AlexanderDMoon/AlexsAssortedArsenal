using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AetheriumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aetherium Bar");
            Tooltip.SetDefault("Lunar metal, refined to it's purest form.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.rare = 11;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "FairiumBar", 2);
            recipe.AddIngredient(ItemID.LunarBar, 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 1);
            recipe.AddIngredient(ItemID.FragmentStardust, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}