using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class RebounderBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rebounder Bullet");
            Tooltip.SetDefault("A low-damage bullet that bounces and/or penetrates up to 10 times. \nRicochets to another nearby targets when striking an enemy. \nIt gains 15% velocity and +2 damage for each bounce.");
		}

        public override void SetDefaults()
        {
            item.damage = 2;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 1);
            item.rare = 3;
            item.shoot = mod.ProjectileType("RebounderBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteorShot, 150);
            recipe.AddIngredient(ItemID.PinkGel, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 150);
			recipe.AddRecipe();
		}
	}
}