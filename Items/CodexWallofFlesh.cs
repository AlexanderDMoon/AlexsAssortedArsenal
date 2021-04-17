using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexWallofFlesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Wall of Flesh");
            Tooltip.SetDefault("Fear. Raw, unfiltered fear screamed through my veins as the Underworld rumbled." +
                               "\nFrom the ash and Hellstone of the landscape rose a wall of raw, burning flesh" +
                               "\npocked with mouths lined with meter-long teeth, and eyes whose gaze chased me" +
                               "\nrelentlessly. How I managed to defeat this horror is beyond me, but I fear that" +
                               "\nI've made a terrible mistake.");
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
                if (npc.type == NPCID.WallofFlesh)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexWallofFlesh"));
                }
            }
        }
    }
}