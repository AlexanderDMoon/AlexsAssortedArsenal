using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogTundra : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Tundra");
            Tooltip.SetDefault("I hope you packed yourself a coat, because this place is cold and the snow goes on for MILES." +
                                "\nAt least the trees here have some nice and shiny wood to build with. I guess that makes up for it." +
                                "\nThe cold temperatures here are bound to slow you down, making this place particularly dangerous" +
                                "\nto an unprepared traveller.");
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
                if (npc.type == NPCID.IceSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogTundra"));
                }

                if (npc.type == NPCID.ZombieEskimo)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogTundra"));
                }

                if (npc.type == NPCID.IceElemental)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogTundra"));
                }

                if (npc.type == NPCID.Wolf)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogTundra"));
                }

                if (npc.type == NPCID.IceGolem)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogTundra"));
                }
            }
        }
    }
}