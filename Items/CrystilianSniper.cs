using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CrystilianSniper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystilian Sniper");
            Tooltip.SetDefault("Fires Crystal bullets when using Musket Shot as ammo. \nHas a high chance to crit.");
        }

        public override void SetDefaults()
        {
            item.damage = 47;
            item.ranged = true;
            item.width = 62;
            item.height = 26;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 3, 50, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 20f;
            item.shoot = 242;
            item.crit = 21;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.CrystalBullet;
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2, -3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ArmadanSniper", 1);
            recipe.AddIngredient(mod, "CrystilianHandgun", 1);
            recipe.AddIngredient(mod, "CrystilianShard", 8);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}