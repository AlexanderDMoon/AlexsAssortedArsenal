using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class PutridPerforator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Putrid Perforator");
            Tooltip.SetDefault("Occasionally fires Blightburn Bullets when using Musket Shot as ammo. \nBlightburn Bullets have a chance to briefly inflict Frostburn and Cursed Inferno.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 70;
            item.height = 28;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 80, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = ProjectileID.Bullet;
            item.crit = 6;
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
                type = Main.rand.Next(new int[] { type, ProjectileID.Bullet, ModContent.ProjectileType<Projectiles.BlightburnBullet>() });
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
            recipe.AddIngredient(mod, "ArcticTypewriter", 1);
            recipe.AddIngredient(ItemID.DemoniteBar, 12);
            recipe.AddIngredient(ItemID.ShadowScale, 6);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}