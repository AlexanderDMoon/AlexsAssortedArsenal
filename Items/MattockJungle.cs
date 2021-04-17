using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockJungle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blossom Mattock");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush. \nHas a chance to dig up small amounts of Jungle materials.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
            item.melee = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 18;
			item.useAnimation = 18;
            item.pick = 50;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.JungleRose, 1);
            recipe.AddIngredient(ItemID.Stinger, 15);
            recipe.AddIngredient(ItemID.JungleSpores, 8);
            recipe.AddIngredient(ItemID.Vine, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}