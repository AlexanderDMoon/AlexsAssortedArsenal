using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class ArmadanSniper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Armadan Sniper");
            Tooltip.SetDefault("Fires a high-velocity bullet when using Musket Shot as ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.ranged = true;
            item.width = 62;
            item.height = 26;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 2, 20, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = 242;
            item.crit = 8;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.BulletHighVelocity;
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, -3);
        }

        public override void HoldItem(Player player)
        {
            player.scope = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Musket or Undertaker", 1);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddIngredient(ItemID.SunplateBlock, 12);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}