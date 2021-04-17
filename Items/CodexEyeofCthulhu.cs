using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexEyeofCthulhu : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Eyes of Cthulhu");
            Tooltip.SetDefault("Among all of the abominations that make up the dangers of the night, none is" +
                               "\nquite as terrifing to behold as the beholder itself; The Eye of Cthulhu. Its" +
                               "\norigins are unknown, but what is obvious is that there is definitely more than" +
                               "\ntwo. I've seen them, drifting carelessly through the air, seemingly only" +
                               "\ndescending to attack only those who hold one of its servants to the night skies." +
                               "\nBut for what purpose...?");
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
                if (npc.type == NPCID.EyeofCthulhu)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexEyeofCthulhu"));
                }
            }
        }
    }
}