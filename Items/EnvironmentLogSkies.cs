using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogSkies : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Skies");
            Tooltip.SetDefault("The skies above you aren't as empty as you may think! The harpies of the world live on islands floating" +
                               "\non clouds, drifting lazily around the world but never quite leaving the skies over the continent. The" +
                               "\nhouses that rest on these islands contain some useful equipment, if you can get past the harpies that" +
                               "\nguard them.");
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
                if (npc.type == NPCID.Harpy)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernLegs)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernBody2)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernBody3)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }

                if (npc.type == NPCID.WyvernTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogSkies"));
                }
            }
        }
    }
}