using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class DemoniteBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonite Bullet");
            Tooltip.SetDefault("Striking an enemy grants you a high defense buff.");
		}

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 2);
            item.rare = 1;
            item.shoot = mod.ProjectileType("DemoniteBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.DemoniteBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}