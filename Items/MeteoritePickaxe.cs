using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MeteoritePickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteorite Pickaxe");
			Tooltip.SetDefault("Cannot mine Hellstone, Obsidian, or Ebonstone/Crimstone. \n'Break the earth with the speed of a falling star.'");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
            item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 6;
			item.useAnimation = 10;
            item.pick = 60;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 12);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Pickaxe", 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}