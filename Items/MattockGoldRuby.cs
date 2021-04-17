using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockGoldRuby : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby-tipped Gold Mattock");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
            item.melee = true;
			item.width = 26;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
            item.pick = 50;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 17, 50);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "MattockGold", 1);
            recipe.AddIngredient(ItemID.Ruby, 4);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}