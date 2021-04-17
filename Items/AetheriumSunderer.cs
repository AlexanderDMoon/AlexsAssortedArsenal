using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AetheriumSunderer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aetherium Sunderer");
			Tooltip.SetDefault("");
		}

        public override void SetDefaults()
        {
            item.damage = 220;
            item.melee = true;
            item.width = 52;
            item.height = 62;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 8, 75, 0);
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrystilianGreatsword", 1);
            recipe.AddIngredient(mod, "AetheriumBar", 7);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}