using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class GeMP44ET : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("GeMP-44 ET");
            Tooltip.SetDefault("Fires Emerald Gemspark bullets that have a chance to briefly inflict Cursed Inferno.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 74;
            item.height = 28;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 7, 50);
            item.rare = 3;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("EmeraldBullet");
            item.crit = 4;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                type = mod.ProjectileType("EmeraldBullet");
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6));
                speedX = perturbedSpeed.X;
                speedY = perturbedSpeed.Y;
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
            recipe.AddIngredient(mod, "FlintlockTungsten", 1);
            recipe.AddIngredient(ItemID.Emerald, 8);
            recipe.AddIngredient(ItemID.TungstenBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}