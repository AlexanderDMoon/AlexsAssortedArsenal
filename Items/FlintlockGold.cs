using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FlintlockGold : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gold Flintlock");
            Tooltip.SetDefault("Fires a Gold Bullet when using Musket Shot as ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 40;
            item.height = 22;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 13, 50);
            item.rare = 0;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 17f;
            item.shoot = ProjectileID.Bullet;
            item.crit = 6;
            item.useAmmo = AmmoID.Bullet;

        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 1);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("GoldBullet");
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddIngredient(ItemID.StoneBlock, 20);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
 