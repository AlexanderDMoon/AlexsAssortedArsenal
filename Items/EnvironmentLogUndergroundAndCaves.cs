using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogUndergroundAndCaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Underground and Caverns");
            Tooltip.SetDefault("Getting your hands dirty is one of many ways you'll be exploring this world. Metal" +
                               "\nores, gems, and golden chests full of treasure await you in the dark caverns beneath" +
                               "\nyour feet, provided you can get through all of the monsters! The reward is worth the" +
                               "\nrisk, as each and every chunk of ore you gather is one step closer to becoming stronger" +
                               "\nthan the enemies that used the plague you.");
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
                if (npc.type == NPCID.Skeleton)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.UndeadMiner)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.BabySlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GraniteFlyer)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GraniteGolem)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.Crawdad)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.CaveBat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.BlueJellyfish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GreenJellyfish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.BlackSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.CochinealBeetle)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GiantWormHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GiantWormBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GiantWormTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GiantShelly)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.Salamander)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.Tim)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.WallCreeper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.AnglerFish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.BlackRecluse)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.GiantBat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.Mimic)
                {
                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.Medusa)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.RuneWizard)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.SkeletonArcher)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.DiggerHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.DiggerBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.DiggerTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }

                if (npc.type == NPCID.ToxicSludge)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundAndCaves"));
                }
            }
        }
    }
}