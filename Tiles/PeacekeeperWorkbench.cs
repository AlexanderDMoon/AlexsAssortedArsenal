using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class PeacekeeperWorkbench : ModItem
    {
          
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Workbench");
            Tooltip.SetDefault("Allows for the crafting of simple Peacekeeper equipment.");
        }
            
        public override void SetDefaults()
        {
            item.width = 54;
            item.height = 20;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("PeacekeeperWorkbench");
        }

        public override void AddRecipes()
        {
            //Weaponsmith Item

            //- 1 Ancient Workbench Fragments (Identified by Analyzer)
            //- 3 Silver OR Tungsten bars
            //- 3 Sapphires

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Silver or Tungsten Bar", 5);
            recipe.AddIngredient(ItemID.Sapphire, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}