using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiaryDungeonMimics : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Dungeon Mimics");
            Tooltip.SetDefault("These creatures seem different from other Mimics. The purpose they serve" +
                               "\nseems to be more coffin-like than chest-like, though destroying them still" +
                               "\nyields quite a bit of treasure- specifically weapons and other deadly things" +
                               "\nwielded by the Dungeon's rabid denisens. As dangerous as they are, I advise" +
                               "\nkilling them for their weapons; They may be useful later on.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 4;
            item.maxStack = 1;
        }
    }
}