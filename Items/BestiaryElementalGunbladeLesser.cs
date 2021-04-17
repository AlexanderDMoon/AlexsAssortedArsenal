using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BestiaryElementalGunbladeLesser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bestiary: Lesser Gunblade Elementals");
            Tooltip.SetDefault("A living revolver haunting the depths of the continent. Sharp, hostile, and thankfully," +
                               "\nseemingly out of ammo. Their preferred method of attack seems to be charging at" +
                               "\ntheir enemy in hopes of impaling them. Though it makes me wonder; Are they really" +
                               "\nammo-less? Or do they save their shots for when they successfully puncture their prey?");
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