using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexBrainofCthulhu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Brain of Cthulhu");
            Tooltip.SetDefault("Never in my life have I been more terrified than when I encountered this massive" +
                               "\nbrain surrounded by floating eyes, watching me with vigor as I dodge and weave" +
                               "\nthrough the horde of eyes charging at me. Destroying the eyes is nearly a death" +
                               "\nsentence, as the Brain enrages and opens, revealing its pumping heart and single," +
                               "\nunblinking eye. After witnessing this eldritch horror, I don't want to imagine" +
                               "\nwhat else could lurk within the pumping blood and lurching organs of the Crimson.");
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
                if (npc.type == NPCID.Creeper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexBrainofCthulhu"));
                }

                if (npc.type == NPCID.BrainofCthulhu)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexBrainofCthulhu"));
                }
            }
        }
    }
}