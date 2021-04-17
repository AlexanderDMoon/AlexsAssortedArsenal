using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class PeacekeeperAnvil : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Anvil");
            Tooltip.SetDefault("Allows for the construction of more intricate pieces of Peacekeeper equipment.");
        }

        public override void SetDefaults()
        {
            item.width = 36;
            item.height = 16;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("PeacekeeperAnvil");
        }

        public override void AddRecipes()
        {
            //Weaponsmith Item

            //- 1 Ancient Anvil Chunks (Identified by Analyzer)
            //- 1 Peacekeeper Charm
            //- 1 Mythril or Orichalcum Anvil

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PeacekeeperCharm", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Mythril or Orichalcum Anvil", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Adamantite or Titanium Bar", 5);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(mod, "PeacekeeperWorkbench");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}