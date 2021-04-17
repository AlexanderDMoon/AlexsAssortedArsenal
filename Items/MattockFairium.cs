using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockFairium : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Saihakken");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush. \nHas a chance to dig up tiny amounts of Hardmode ores. \nCannot mine Chlorophyte.");
		}

		public override void SetDefaults()
		{
			item.damage = 24;
            item.melee = true;
			item.width = 28;
			item.height = 28;
			item.useTime = 20;
			item.useAnimation = 20;
            item.pick = 175;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 3, 75, 0);
            item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}