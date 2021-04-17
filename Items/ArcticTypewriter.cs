using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class ArcticTypewriter : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arctic Typewriter");
            Tooltip.SetDefault("Occasionally fires Frostburn Bullets when using Musket Shot as ammo. \n'Myeh, see?'");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 64;
            item.height = 22;
            item.useTime = 11;
            item.useAnimation = 11;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = ProjectileID.Bullet;
            item.crit = 4;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(4));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
            }

            if (type == ProjectileID.Bullet)
            {
                type = Main.rand.Next(new int[] { type, ProjectileID.Bullet, ModContent.ProjectileType<Projectiles.FrostburnBullet>() });
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "Cold96", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Bar", 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}