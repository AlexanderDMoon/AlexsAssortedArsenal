using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogMeteorite : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: Meteorites");
            Tooltip.SetDefault("Aaah, meteorite. A lovely material, if you can get your hands on it without burning yourself to death." +
                               "\nI remember the first time I saw a meteor fall on the world. It was incredible! But not as incredible" +
                               "\nas the material itself; Its magical properties make excellent armour and weaponry. Be careful, though-" +
                               "\nthere are far more dangers to these space rocks than the heat they contain.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 4;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.MeteorHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogMeteorite"));
                }
            }
        }
    }
}