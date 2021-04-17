using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class OfficeDesk : ModItem
    {
          
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Office Desk");
            Tooltip.SetDefault("A simple workplace desk.");
        }
            
        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("OfficeDesk");
        }

        public override void AddRecipes()
        {
        }
    }
}