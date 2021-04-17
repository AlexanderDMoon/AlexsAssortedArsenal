using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class PearlstoneBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pearlstone Bullet");
            Tooltip.SetDefault("Deals 50% more damage to Corrupt/Crimson enemies.");
		}

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = 10;
            item.rare = 2;
            item.shoot = mod.ProjectileType("PearlstoneBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}