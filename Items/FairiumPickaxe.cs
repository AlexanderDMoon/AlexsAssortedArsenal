using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FairiumPickaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Pickaxe");
			Tooltip.SetDefault("'Waiting is overrated.'");
		}

		public override void SetDefaults()
		{
			item.damage = 21;
            item.melee = true;
			item.width = 42;
			item.height = 42;
			item.useTime = 5;
			item.useAnimation = 14;
            item.pick = 205;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PickaxeAxe, 1);
            recipe.AddIngredient(mod, "FairiumBar", 8);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}