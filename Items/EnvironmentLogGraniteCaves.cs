using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogGraniteCaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: Granite Caves");
            Tooltip.SetDefault("What a lovely shade of blue! These caves made purely out of granite are a beautiful sight" +
                               "\nto behold, and sometimes contain some very useful equipment. Caution must still be taken" +
                               "\nthough, as the granite will more often than not animate itself into golems and elementals" +
                               "\ncapable of shielding themselves from damage and delivering some devastating punches.");
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
                if (npc.type == NPCID.GraniteGolem)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGraniteCaves"));
                }

                if (npc.type == NPCID.GraniteFlyer)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGraniteCaves"));
                }
            }
        }
    }
}