using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexDukeFishron : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: Duke Fishron");
            Tooltip.SetDefault("A mighty beast hailing from the depths of the Ocean; Duke Fishron is a" +
                               "\nforce to be reckoned with. The few people that have managed to summon" +
                               "\nthe beast never lived to tell the tale, but I can obviously see that the" +
                               "\nresults are far different for you. I advise you take caution, however; I" +
                               "\ncan imagine that killing too many of this species can harshly damage the" +
                               "\nOcean's ecosystem.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 6;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.DukeFishron)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexDukeFishron"));
                }
            }
        }
    }
}