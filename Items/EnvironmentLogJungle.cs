using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogJungle : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Jungle");
            Tooltip.SetDefault("Perhaps one of the most dangerous biomes on the surface, the Jungle is not a friendly place" +
                               "\nfor anyone, really. Sure, the bright green plantlife and teal waters seem inviting, but" +
                               "\nit'll kill you quick if you let your guard down. Travelling through here is rough, so I hope" +
                               "\nyou've got enough equipment to get through here quick!");
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
                if (npc.type == NPCID.JungleBat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.JungleSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.GiantTortoise)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.AngryTrapper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.Arapaima)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.GiantFlyingFox)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }

                if (npc.type == NPCID.Derpling)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogJungle"));
                }
            }
        }
    }
}