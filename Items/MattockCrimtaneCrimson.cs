using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockCrimtaneCrimson : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crimson Mattock");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
            item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 18;
			item.useAnimation = 18;
            item.pick = 50;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MattockCrimtane", 1);
            recipe.AddIngredient(ItemID.TissueSample, 4);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}