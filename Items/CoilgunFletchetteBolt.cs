using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CoilgunFletchetteBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fletchette Coilgun Bolt");
            Tooltip.SetDefault("A powerful metal spike that trades damage for insane speed and piercing capability.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 10;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 7);
            item.rare = 3;
            item.shoot = mod.ProjectileType("CoilgunFletchetteBolt");
            item.shootSpeed = 3f;
            item.ammo = mod.ProjectileType("CoilgunBolt");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CoilgunBolt", 150);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }
}