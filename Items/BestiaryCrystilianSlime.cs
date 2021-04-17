using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiaryCrystilianSlime : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Crystilian Slime");
            Tooltip.SetDefault("A mysterious, almost otherworldly slime that has emerged from the Hallow." +
                               "\nIts crystalline makeup seems to make it quite dense; Seemingly TOO dense," +
                               "\nhowever. It currently doesn't seem capable of firing its spikes and instead" +
                               "\nopts to leap toward its foes in an attempt to impale them. I advise caution" +
                               "\nwhen approaching these.");
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