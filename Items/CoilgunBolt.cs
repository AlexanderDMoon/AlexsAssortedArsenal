using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CoilgunBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Coilgun Bolt");
            Tooltip.SetDefault("A powerful metal spike that pierces multiple enemies.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 6;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 7);
            item.rare = 3;
            item.shoot = mod.ProjectileType("CoilgunBolt");
            item.shootSpeed = 3f;
            item.ammo = mod.ProjectileType("CoilgunBolt");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Adamantite or Titanium Bar", 1);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 75);
            recipe.AddRecipe();
        }
    }
}