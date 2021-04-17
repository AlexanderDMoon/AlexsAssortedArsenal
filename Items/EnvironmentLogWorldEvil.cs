using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogWorldEvil : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The World's Evil");
            Tooltip.SetDefault("Oh, why me? Why did I have to come here to study this place? I regret everything I've done leading" +
                               "\nup to me being here. This place is awful, and I hope you don't stay here as long as I have to." +
                               "\nIt's more dangerous than any natural place in the world... Though I fear it may be the one thing" +
                               "\nthat helps strike balance in it.");
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
                if (npc.type == NPCID.EaterofSouls)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BigEater)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.LittleEater)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.CorruptGoldfish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.DevourerHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.DevourerBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.DevourerTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.EaterofWorldsHead)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.EaterofWorldsBody)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.EaterofWorldsTail)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Corruptor)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Clinger)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Slimeling)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Slimer)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.SeekerHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.SeekerBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.SeekerTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.DarkMummy)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BloodCrawler)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.CrimsonGoldfish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.CrimsonBunny)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.FaceMonster)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BigCrimera)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.LittleCrimera)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Crimera)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Creeper)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Herpling)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BigCrimslime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.LittleCrimslime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.Crimslime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BloodJelly)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.BloodFeeder)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }

                if (npc.type == NPCID.CrimsonAxe)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogWorldEvil"));
                }
            }
        }
    }
}