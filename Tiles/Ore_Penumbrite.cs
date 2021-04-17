using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class Ore_Penumbrite : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Penumbrite Ore");
            Tooltip.SetDefault("please ignore this if you're seeing it in cheat sheet i have no idea what its doing here");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 0;
            item.consumable = true;
            item.createTile = mod.TileType("Ore_Penumbrite");
        }
    }
}