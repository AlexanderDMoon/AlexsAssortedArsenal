using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiarySoulWisps : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Wisps of Light and Night");
            Tooltip.SetDefault("It seems like there was a larger purpose to those mechanical beasts" +
                               "\nother than just causing destruction. They seem to also behave as a" +
                               "\nsort of 'seal', keeping the souls of the world at bay. Destroying" +
                               "\njust one of the mechs seems to have weakened the seal enough for it" +
                               "\nto break and release them, and now these souls wander aimlessly through" +
                               "\nthe Hallow and World Evil. I wonder how long they've been held captive?");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 4;
            item.maxStack = 1;
        }
    }
}