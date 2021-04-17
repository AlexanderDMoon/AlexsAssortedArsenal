using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogUndergroundTundra : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Underground Tundra");
            Tooltip.SetDefault("And just when you thought the world couldn't get any colder, you dived into the snow" +
                               "\nand broke into a frozen cave. I admire your resolve; It personally took me several weeks to" +
                               "\nmentally prepare myself for the cold! Be careful though, and tread a little more lightly" +
                               "\nthan usual. You never know when the ice might break beneath your feet.");
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
                if (npc.type == NPCID.SpikedIceSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.CyanBeetle)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.IceBat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.SnowFlinx)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.UndeadViking)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.IceTortoise)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.ArmoredViking)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }

                if (npc.type == NPCID.IcyMerman)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUndergroundTundra"));
                }
            }
        }
    }
}