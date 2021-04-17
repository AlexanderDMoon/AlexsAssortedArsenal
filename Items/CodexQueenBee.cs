using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexQueenBee : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: Queen Bees");
            Tooltip.SetDefault("Oooh, the mistakes I've made. Breaking into one of the jungles many, massive beehives was" +
                               "\nalready a dumb idea. Breaking into one, then falling and smashing the Queen's larvae? I'm" +
                               "\nsurprised I got out with what injuries I sustained. I surely would have died if it wasn't" +
                               "\nfor the vitality-bolstering properties of the honey that floods these hives. Never again" +
                               "\nwill I try to explore one of these, lest I end up disrupting the ecosystem by slaying the" +
                               "\ninsects that support it.");
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
                if (npc.type == NPCID.QueenBee)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexQueenBee"));
                }
            }
        }
    }
}