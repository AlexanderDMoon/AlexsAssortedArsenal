using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class SolarWind : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Solar Wind");
            Tooltip.SetDefault("Uses Gel for ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 82;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item34;
            item.autoReuse = true;
            item.shootSpeed = 6f;
            item.shoot = 85;
            item.crit = 1;
            item.useAmmo = AmmoID.Gel;
        }

        //public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        //{
        //   {
        //        Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
        //        speedX = perturbedSpeed.X;
        //        speedY = perturbedSpeed.Y;
        //    }
        //    return true;
        //}

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-1, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 15);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}