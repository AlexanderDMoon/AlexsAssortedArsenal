using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogMarbleCaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: Marble Caves");
            Tooltip.SetDefault("The beautiful sheen of this bright white marble manages to hide a rather terrifying" +
                               "\nset of secrets. Skeletal gladiators with javelins and snake women capable of turning" +
                               "\nyou into stone may just be the last things you see here, but if you can survive the" +
                               "\ndangers these creatures bring, then bountiful treasure and a rather pretty building" +
                               "\nmaterial awaits you.");
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
                if (npc.type == NPCID.Medusa)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogMarbleCaves"));
                }

                if (npc.type == NPCID.GreekSkeleton)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogMarbleCaves"));
                }
            }
        }
    }
}