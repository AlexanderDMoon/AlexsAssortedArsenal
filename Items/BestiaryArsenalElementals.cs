using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiaryArsenalElementals : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Elementals of the Arsenal");
            Tooltip.SetDefault("Strange creatures have started appearing all across the continent, observing" +
                               "\nand attacking anyone who comes across them. Where did they come from? For what" +
                               "\npurpose do they exist, and were they created by someone? I've heard tales of these" +
                               "\n'Elementals' before; Living embodiments of various armaments. Guns with blades," +
                               "\ngunpowder, bullets- The list goes on, and so does the list of potential horrors." +
                               "\nWhatever the source of these creatures, we need to stop them before they become" +
                               "\ntoo powerful to contain.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 5;
            item.maxStack = 1;
        }
    }
}