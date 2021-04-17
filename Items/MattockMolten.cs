using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockMolten : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Mattock");
			Tooltip.SetDefault("Has a chance to extract rare treasures when mining Silt and Slush. \nHas a chance to dig up tiny amounts of Hellstone or Obsidian. \nCannot mine Cobalt or Palladium.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
            item.melee = true;
			item.width = 24;
			item.height = 26;
			item.useTime = 20;
			item.useAnimation = 20;
            item.pick = 60;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 45, 0);
            item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ItemID.Obsidian, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}