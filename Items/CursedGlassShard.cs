using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CursedGlassShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shard of Cursed Glass");
            Tooltip.SetDefault("Increases damage dealt by 175%. \nIncreases damage taken by 225%. \nIncreases enemy spawnrates. \n'Unfair? Maybe. Fun? ...I guess it depends?'");
		}

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 36;
            item.value = Item.sellPrice(0, 12, 0, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 1.75f;
            player.GetModPlayer<AAAModPlayer>().CursedGlassShardEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 250);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Demonite or Crimtane Bar", 30);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Shadow Scales or Tissue Samples", 30);
            recipe.AddIngredient(ItemID.HellstoneBar, 10);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}