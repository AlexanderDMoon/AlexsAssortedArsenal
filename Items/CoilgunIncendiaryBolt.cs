using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CoilgunIncendiaryBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Incendiary Coilgun Bolt");
            Tooltip.SetDefault("A powerful metal spike that pierces multiple enemies and sets them ablaze, at the cost of less damage and piercing.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 6;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 7);
            item.rare = 3;
            item.shoot = mod.ProjectileType("CoilgunIncendiaryBolt");
            item.shootSpeed = 3f;
            item.ammo = mod.ProjectileType("CoilgunBolt");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CoilgunBolt", 150);
            recipe.AddIngredient(ItemID.Hellstone, 3);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }
}