using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockCopper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Mattock");
			Tooltip.SetDefault("Has a chance to extract common treasures when mining Silt and Slush.");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
            item.melee = true;
			item.width = 24;
			item.height = 26;
			item.useTime = 25;
			item.useAnimation = 25;
            item.pick = 35;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 75);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 8);
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}