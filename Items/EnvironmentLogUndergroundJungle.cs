using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogUndergroundJungle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Underground Jungle");
            Tooltip.SetDefault("A dank, dark and incredibly dangerous labyrinth of moss, mud and hornet nests. While there are" +
                               "\nnumerous dangers in the Underground Jungle, there are still a wealth of treasures to find." +
                               "\nTread carefully, though- There are killer plants, giant hornets with equally large hives," +
                               "\nand other horrors that'll kill you and eat you whole, if given the chance.");
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
                if (npc.type == NPCID.JungleBat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.DoctorBones)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.Hornet)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.MossHornet)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.ManEater)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.SpikedJungleSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.Lihzahrd)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.FlyingSnake)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.Moth)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.GiantTortoise)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.AngryTrapper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.Arapaima)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }

                if (npc.type == NPCID.JungleCreeper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundJungle"));
                }
            }
        }
    }
}