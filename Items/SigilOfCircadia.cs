using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SigilOfCircadia : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sigil of Circadia");
            Tooltip.SetDefault("Increases all damage by 18% \nIncreases Defense by 8. \nAll attacks inflict a powerful, damaging debuff. \n'Will you two shut up already?'");
		}

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 9, 50, 0);
            item.rare = 11;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.allDamage += 0.18f;
            player.statDefense += 8;
            player.GetModPlayer<AAAModPlayer>().SigilofCircadiaEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CharmOfTsuki", 1);
            recipe.AddIngredient(mod, "CharmOfNami", 1);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.FragmentStardust, 10);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddTile(mod, "PeacekeeperForge");
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}