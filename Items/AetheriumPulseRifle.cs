using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class AetheriumPulseRifle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Pulse Rifle");
            Tooltip.SetDefault("Fires a burst of three high-velocity life-leeching bullets when using Musket Shot as ammo. \nThere is a somewhat long delay between bursts.");
        }

        public override void SetDefaults()
        {
            item.damage = 62;
            item.ranged = true;
            item.width = 64;
            item.height = 24;
            item.useTime = 4;
            item.useAnimation = 12;
            item.reuseDelay = 26;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 8, 75, 0);
            item.rare = 10;
            item.UseSound = SoundID.Item31;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("AetheriumRifleShot");
            item.crit = 8;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("AetheriumRifleShot");
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
            recipe.AddIngredient(mod, "CrystilianCarbine", 1);
            recipe.AddIngredient(mod, "AetheriumBar", 7);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}