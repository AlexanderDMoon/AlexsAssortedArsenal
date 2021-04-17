using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexLunarPillars : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Lunar Pillars");
            Tooltip.SetDefault("Vast pillars, several dozens of meters in height have formed across the continent," +
                               "\nharboring many otherworldy beings of great power. What master do they serve? Why" +
                               "\nare they so interested in our world, to the point of invasion? To what level of" +
                               "\nimportance did that Lunatic Cultist serve to have warranted this invasion? I can" +
                               "\nonly hope that you have the strength to fight them off.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 8;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.LunarTowerSolar)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.LunarTowerNebula)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.LunarTowerStardust)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.LunarTowerVortex)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustWormHead)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustWormBody)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustWormTail)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustCellSmall)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustJellyfishBig)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustSpiderBig)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.StardustSoldier)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarCrawltipedeHead)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarCrawltipedeBody)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarCrawltipedeTail)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarDrakomire)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarDrakomireRider)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarSroller)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarCorite)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.SolarSolenian)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.NebulaBrain)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.NebulaHeadcrab)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.NebulaBeast)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.NebulaSoldier)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.VortexRifleman)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.VortexHornetQueen)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.VortexHornet)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.VortexLarva)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }

                if (npc.type == NPCID.VortexSoldier)
                {
                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunarPillars"));
                }
            }
        }
    }
}