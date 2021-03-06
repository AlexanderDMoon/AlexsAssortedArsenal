using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class TopazBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Gemspark Bullet");
            Tooltip.SetDefault("Has a chance to inflict Ichor.");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 12;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 15);
            item.rare = 3;
            item.shoot = mod.ProjectileType("TopazBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 1);
            recipe.AddIngredient(ItemID.PixieDust, 3);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddIngredient(ItemID.EmptyBullet, 50);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}