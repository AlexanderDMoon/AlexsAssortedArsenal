using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogOcean : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Oceans");
            Tooltip.SetDefault("Another peaceful place in an otherwise hostile world, the Oceans on either side of the continent" +
                               "\nare a lovely place to sit down and relax, so long as you don't put your feet in the water. Sharks," +
                               "\njellyfish and crabs are some of many dangers that lurk in the deep. And, if you really believe in" +
                               "\nmyths and legends, you may even hear quite an alluring song...");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 3;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Crab)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogOcean"));
                }

                if (npc.type == NPCID.Squid)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogOcean"));
                }

                if (npc.type == NPCID.SeaSnail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogOcean"));
                }

                if (npc.type == NPCID.PinkJellyfish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogOcean"));
                }

                if (npc.type == NPCID.Shark)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogOcean"));
                }
            }
        }
    }
}