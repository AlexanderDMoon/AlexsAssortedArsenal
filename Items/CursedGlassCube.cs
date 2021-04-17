using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CursedGlassCube : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cube of Cursed Glass");
            Tooltip.SetDefault("Increases damage dealt by 275%. \nIncreases damage taken by 325%. \nIncreases enemy spawnrates.");
		}

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 28;
            item.value = Item.sellPrice(0, 40, 0, 0);
            item.rare = 6;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 2.75f;
            player.GetModPlayer<AAAModPlayer>().CursedGlassCubeEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CursedGlassShard", 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 20);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddIngredient(ItemID.SoulofFright, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 25);
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}