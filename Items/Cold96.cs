using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Cold96 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cold-96");
            Tooltip.SetDefault("Occasionally fires Frostburn Bullets when using Musket Shot as ammo. \nFrostburn Bullets have a small chance to briefly inflict Frostburn.");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 36;
            item.height = 20;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = ProjectileID.Bullet;
            item.crit = 8;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = Main.rand.Next(new int[] { type, ProjectileID.Bullet, ModContent.ProjectileType<Projectiles.FrostburnBullet>() });
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, 1);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlock, 12);
            recipe.AddIngredient(ItemID.BorealWood, 5);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Iron or Lead Bar", 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}