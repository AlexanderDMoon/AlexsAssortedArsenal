using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnchantedSilverBullet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Silver Bullet");
            Tooltip.SetDefault("Deals more damage to Werewolves and other mythical creatures of horror. \nStriking an enemy grants a moderate defensive buff.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 24;
            item.height = 24;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 7);
            item.rare = 3;
            item.shoot = mod.ProjectileType("EnchantedSilverShot");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverBullet, 50);
            recipe.AddIngredient(ItemID.PixieDust, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}