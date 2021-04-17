using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class RubicoPrime : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rubico Prime");
            Tooltip.SetDefault("This blatant reference to Warframe fires a powerful, ultra-piercing high-velocity bullet when using Musket Shot as ammo. \nRight-click to zoom out. \n'Dream... not of what you are, but of what you want to be.'");
		}

        public override void SetDefaults()
        {
            item.damage = 310;
            item.ranged = true;
            item.width = 160;
            item.height = 54;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 16, 35, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("PrimeBullet");
            item.crit = 38;
            item.useAmmo = AmmoID.Bullet;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("PrimeBullet");
            }

            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-36, -5);
        }

        public override void HoldItem(Player player)
        {
            player.scope = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Hellraiser", 1);
            recipe.AddIngredient(ItemID.SniperRifle, 1);
            recipe.AddIngredient(ItemID.SniperScope, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 16);
            recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddTile(TileID.LunarCraftingStation); //This will be the Forge of the Ancients at some point.
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
 