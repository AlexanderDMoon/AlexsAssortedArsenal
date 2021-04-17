using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class ArmadanBroadsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armadan Broadsword");
			Tooltip.SetDefault("");
		}

        public override void SetDefaults()
        {
            item.damage = 21;
            item.melee = true;
            item.width = 54;
            item.height = 54;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 33, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Light's Bane or Blood Butcherer", 1);
            recipe.AddIngredient(ItemID.Feather, 6);
            recipe.AddIngredient(ItemID.SunplateBlock, 15);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}