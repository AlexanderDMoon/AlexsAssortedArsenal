using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexPlantera : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: Plantera");
            Tooltip.SetDefault("No... No, no no no... This is what I was warned about. What the old man at" +
                               "\nthe Dungeon told me, about spirits culminating at one place in the world." +
                               "\nIt was Plantera, the collective, peaceful vessel in which all of the nature-" +
                               "\nbound spirits controlled in unison; One mind, one body, countless souls." +
                               "\nI can feel their anger in the air. Screams echo from the one place I could" +
                               "\nnever conquer. What have we done?");
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
                if (npc.type == NPCID.Plantera)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexPlantera"));
                }
            }
        }
    }
}