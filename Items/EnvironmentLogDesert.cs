using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogDesert : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Desert");
            Tooltip.SetDefault("Hooh boy, where do I begin? Sweltering heat, endless sand, prickly cactuses, the list of" +
                                "\ndangers goes on and on. Not to mention the sandstorms- those'll kill you in a heartbeat if" +
                                "\nyou're not careful! If you can survive those, then I certainly believe you can survive the" +
                                "\ncreatures that live here. However, I still recommend new arrivals to not spend too much time" +
                                "\nhere; The desert is a volatile and dangerous place.");
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
                if (npc.type == NPCID.Antlion)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.Vulture)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.Tumbleweed)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.SandSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.Mummy)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.DuneSplicerHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.DuneSplicerBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }

                if (npc.type == NPCID.DuneSplicerTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDesert"));
                }
            }
        }
    }
}