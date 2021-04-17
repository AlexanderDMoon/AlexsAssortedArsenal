using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockTinTopaz : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Topaz-tipped Tin Mattock");
			Tooltip.SetDefault("Has a chance to extract common treasures when mining Silt and Slush.");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
            item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 25;
			item.useAnimation = 25;
            item.pick = 35;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 1, 5);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MattockTin", 1);
            recipe.AddIngredient(ItemID.Topaz, 4);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}