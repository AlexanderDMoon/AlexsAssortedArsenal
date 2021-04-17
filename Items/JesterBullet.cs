using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class JesterBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jester's Bullet");
            Tooltip.SetDefault("A low-damage bullet that pierces up to 20 enemies.");
        }

        public override void SetDefaults()
        {
            item.damage = 2;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 15);
            item.rare = 1;
            item.shoot = mod.ProjectileType("JesterBullet");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddIngredient(ItemID.MusketBall, 30);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
}