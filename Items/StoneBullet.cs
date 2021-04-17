using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class StoneBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Bullet");
            Tooltip.SetDefault("A weak but cheap alternative to Musket Balls.");
		}

        public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 0;
            item.shoot = mod.ProjectileType("StoneBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}