using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Greatsword");
			Tooltip.SetDefault("Has high damage and moderate knockback.");
		}

        public override void SetDefaults()
        {
            item.damage = 95;
            item.melee = true;
            item.width = 72;
            item.height = 80;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 3, 25, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 21;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddIngredient(mod, "ArmadanBroadsword", 1);
            recipe.AddIngredient(mod, "CrystilianShard", 12);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Cobalt or Palladium Bar", 5);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}