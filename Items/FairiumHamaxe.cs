using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FairiumHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Hamaxe");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
            item.melee = true;
			item.width = 48;
			item.height = 42;
			item.useTime = 12;
			item.useAnimation = 23;
            item.axe = 22;
            item.hammer = 85;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}