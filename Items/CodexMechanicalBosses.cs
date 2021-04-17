using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexMechanicalBosses : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Mechanical Bosses");
            Tooltip.SetDefault("What idiot decided these things were a good idea? For what purpose do these" +
                               "\nmachines serve? Who the hell built these things? Whatever they are, whatever" +
                               "\npurpose they were made for, I'm glad you've begun putting an end to them." +
                               "\nI just hope these weren't mass-produced.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 5;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Retinazer)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }

                if (npc.type == NPCID.Spazmatism)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }

                if (npc.type == NPCID.TheDestroyer)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }

                if (npc.type == NPCID.TheDestroyerBody)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }

                if (npc.type == NPCID.TheDestroyerTail)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }

                if (npc.type == NPCID.SkeletronPrime)
                {
                    if (Main.rand.Next(75) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMechanicalBosses"));
                }
            }
        }
    }
}