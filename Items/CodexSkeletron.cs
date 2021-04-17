using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexSkeletron : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: Skeletron");
            Tooltip.SetDefault("Never again will I ever come near to the Dungeon. The old man that lives at its entrance" +
                               "\nis enslaved by some 'demon of the Underworld', forcing him to be its immortal vessel. I" +
                               "\noffered to try and free him, and challenged his master. I only just barely escaped with" +
                               "\nmy life, and hardly much else. The monster was too much for me to handle.");
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
                if (npc.type == NPCID.SkeletronHead)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexSkeletron"));
                }
            }
        }
    }
}