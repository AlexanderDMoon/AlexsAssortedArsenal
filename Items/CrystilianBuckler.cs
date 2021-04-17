using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianBuckler : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Buckler");
            Tooltip.SetDefault("Increases Defense by 5. \nIncreases Melee damage by 7%. \nIncreases Melee crit chance by 5%.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.value = Item.sellPrice(0, 1, 15, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 5;
            player.meleeDamage += 0.07f;
            player.meleeCrit += 5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrystilianShard", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}