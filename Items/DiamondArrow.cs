using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class DiamondArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Diamond Gemspark Arrow");
            Tooltip.SetDefault("Pierces one enemy.");
		}

        public override void SetDefaults()
        {
            item.damage = 11;
            item.ranged = true;
            item.width = 12;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 15);
            item.rare = 3;
            item.shoot = mod.ProjectileType("DiamondArrow");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Diamond, 1);
            recipe.AddIngredient(ItemID.PixieDust, 3);
            recipe.AddIngredient(ItemID.WoodenArrow, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}