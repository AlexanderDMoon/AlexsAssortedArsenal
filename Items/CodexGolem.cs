using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexGolem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Golem");
            Tooltip.SetDefault("The idol of the Lihzahrd people, built in the image of the Sun. To them," +
                               "\nthe Sun must be some sort of... mythical being? Some sort of abnormal" +
                               "\noccurance? I don't blame them for thinking that way; Living underground" +
                               "\nfor most of your life is bound to make you wary of a bright ball of fire" +
                               "\nabove your head. But I'm still curious... Why was this golem built for" +
                               "\ncombat? Was it just to defend their temple, or was there some nefarious" +
                               "\npurpose to the Golem?");
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
                if (npc.type == NPCID.Golem)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexGolem"));
                }
            }
        }
    }
}