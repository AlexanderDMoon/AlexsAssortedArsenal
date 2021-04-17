using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogForest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Forest");
            Tooltip.SetDefault("Where everyone begins their adventure; It's a peaceful place! Or at least, while the sun is up." +
                "\nGreen grass, tall trees and little danger. Well, comparitively to other parts of the world, at least." +
                "\nI often found myself laying in the grass, enjoying the sun and the calm wind. And you may end up doing" +
                "\nthe same, though I'd advise keeping a weapon with you; the slimes are a bit pesky at times.");
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
                if (npc.type == NPCID.BlueSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.GreenSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.PurpleSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.RedSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.YellowSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.UmbrellaSlime)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.Zombie)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.DemonEye)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.AngryNimbus)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.Werewolf)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }

                if (npc.type == NPCID.Wraith)
                {
                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogForest"));
                }
            }
        }
    }
}