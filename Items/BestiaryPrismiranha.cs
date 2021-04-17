using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiaryPrismiranha : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Aquamarine Biter");
            Tooltip.SetDefault("An unusual, ocean-dwelling cousin of the freshwater piranha. Its shiny scales," +
                               "\nas it's name would suggest, are made of aquamarine. How it manages to create" +
                               "\nscales out of this mineral is unknown; However, it's most definitely obvious" +
                               "\nthat this bad-natured creature is abundant in the waters. Watch your toes!");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 3;
            item.maxStack = 1;
        }
    }
}