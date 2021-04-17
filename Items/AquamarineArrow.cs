using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AquamarineArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine Gemspark Arrow");
            Tooltip.SetDefault("Ignores water and deals more damage to Fire-based enemies.");
		}

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 14;
            item.height = 40;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 3;
            item.shoot = mod.ProjectileType("AquamarineArrow");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Aquamarine", 1);
            recipe.AddIngredient(ItemID.PixieDust, 3);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}