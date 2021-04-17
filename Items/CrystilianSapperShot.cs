using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianSapperShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Sapper Shot");
            Tooltip.SetDefault("A low-damage bullet capable of leeching life from enemies.");
		}

        public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.width = 10;
            item.height = 18;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 0;
            item.value = Item.sellPrice(0, 0, 0, 6);
            item.rare = 4;
            item.shoot = mod.ProjectileType("CrystilianSapperShot");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrystilianShard", 1);
            recipe.AddIngredient(ItemID.MusketBall, 35);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 35);
			recipe.AddRecipe();
		}
	}
}