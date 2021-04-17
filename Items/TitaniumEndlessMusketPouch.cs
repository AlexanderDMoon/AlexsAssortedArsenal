using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class TitaniumEndlessMusketPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Musket Pouch (Titanium)");
            Tooltip.SetDefault("Contains an unlimited amount of confusion-inducing Titanium Bullets.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 26;
            item.height = 34;
            item.maxStack = 1;
            item.consumable = false;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = 3;
            item.shoot = mod.ProjectileType("TitaniumMusketBall");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TitaniumMusketBall", 3996);
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}