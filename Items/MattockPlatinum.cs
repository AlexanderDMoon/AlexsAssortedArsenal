using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockPlatinum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Platinum Mattock");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
            item.melee = true;
			item.width = 24;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
            item.pick = 50;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 25, 50);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumBar, 8);
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}