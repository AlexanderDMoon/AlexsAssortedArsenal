using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexEaterofWorlds : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Eater of Worlds");
            Tooltip.SetDefault("Thank the stars this thing doesn't actually eat entire worlds. What it is capable" +
                               "\nof eating, however, is an entire human if one isn't evasive enough. Its sharp" +
                               "\nteeth can puncture even solid tungsten, and slicing its body in half only reveals" +
                               "\nanother face hidden beneath the flesh, splitting the worm into two seperate," +
                               "\nliving entities like some sick, infested hydra. I don't know if killing these" +
                               "\nthings will weaken the Corruption, but we can only hope.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 4;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.EaterofWorldsHead)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexEaterofWorlds"));
                }

                if (npc.type == NPCID.EaterofWorldsBody)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexEaterofWorlds"));
                }

                if (npc.type == NPCID.EaterofWorldsTail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexEaterofWorlds"));
                }
            }
        }
    }
}