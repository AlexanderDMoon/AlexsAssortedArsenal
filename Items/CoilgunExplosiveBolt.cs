using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CoilgunExplosiveBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Explosive Coilgun Bolt");
            Tooltip.SetDefault("A powerful metal spike tipped with explosives. \nFizzles out if striking a solid surface; Strike an enemy for full effect.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 6;
            item.height = 26;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 8);
            item.rare = 3;
            item.shoot = mod.ProjectileType("CoilgunExplosiveBolt");
            item.shootSpeed = 3f;
            item.ammo = mod.ProjectileType("CoilgunBolt");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CoilgunBolt", 150);
            recipe.AddIngredient(mod, "GunpowderCore", 3);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 150);
            recipe.AddRecipe();
        }
    }
}