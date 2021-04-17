using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class IronBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Bullet");
            Tooltip.SetDefault("Striking an enemy grants a minor defensive buff.");
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
            item.value = Item.sellPrice(0, 0, 0, 1);
            item.rare = 0;
            item.shoot = mod.ProjectileType("IronBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}