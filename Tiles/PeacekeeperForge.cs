using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class PeacekeeperForge : ModItem
    {
          
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Forge");
            Tooltip.SetDefault("The birthplace for the most iconic of gadgets for heroes the world over.");
        }
            
        public override void SetDefaults()
        {
            item.width = 48;
            item.height = 32;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("PeacekeeperForge");
        }

        public override void AddRecipes()
        {
            //Weaponsmith Item

            //- 1 Ancient Furnace Components (Identified by Analyzer)
            //- 3 Souls of Might, Sight AND Fright
            //- 5 Spectre Bars

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PeacekeeperCharm", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Adamantite or Titanium Forge", 1);
            recipe.AddIngredient(ItemID.SoulofMight, 3);
            recipe.AddIngredient(ItemID.SoulofSight, 3);
            recipe.AddIngredient(ItemID.SoulofFright, 3);
            recipe.AddIngredient(ItemID.SpectreBar, 8);
            recipe.AddTile(mod, "PeacekeeperAnvil");
            recipe.AddTile(mod, "PeacekeeperWorkbench");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}