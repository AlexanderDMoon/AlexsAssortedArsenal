using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogUndergroundDesert : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Underground Desert");
            Tooltip.SetDefault("A hostile and annoyingly sandy place filled with dangerous bugs and spikes of sandstone." +
                               "\nIf you can survive the charging Antlions, winding caves and clausterphobia, then many" +
                               "\ntreasures await you! You might also find lots of fossils here, though they might be" +
                               "\na little too tough for your pickaxe.");
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
                if (npc.type == NPCID.WalkingAntlion)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.FlyingAntlion)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.TombCrawlerHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.TombCrawlerBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.TombCrawlerTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.DesertBeast)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.DesertLamiaLight)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.DesertLamiaDark)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }

                if (npc.type == NPCID.DesertGhoul)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundDesert"));
                }
            }
        }
    }
}