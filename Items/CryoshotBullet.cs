using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CryoshotBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cryoshot Bullet");
            Tooltip.SetDefault("Has a chance to inflict a devastating damage over time debuff. \nStriking an enemy grants you a defense and regen-boosting buff.");
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
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.rare = 6;
            item.shoot = mod.ProjectileType("Cryoshot");
            item.shootSpeed = 2f;
            item.ammo = AmmoID.Bullet;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(mod, "SoulofChills", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}