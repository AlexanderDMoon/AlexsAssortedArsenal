using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogUnderworld : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Underworld");
            Tooltip.SetDefault("I've dug too deep. Upon finding a layer of fine ash, I plunged my pickaxe into it only for the" +
                               "\nfloor to collapse beneath me. I landed on the edge of what seems to be a structure made of" +
                               "\nobsidian brick, with lava on every side of me. There are glowing veins of red stone all over the" +
                               "\nplace, guarded by imps, demons and serpents made of bone. I've only heard tales of this so-called" +
                               "\n'Hellstone', but after seeing it with my own two eyes, I had to gather it. And you should, too-" +
                               "\nyou may need it just as much, if not more, than I have.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 5;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.FireImp)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.Demon)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.VoodooDemon)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.LavaSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.Hellbat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.DemonTaxCollector)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.Lavabat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }

                if (npc.type == NPCID.RedDevil)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogUnderworld"));
                }
            }
        }
    }
}