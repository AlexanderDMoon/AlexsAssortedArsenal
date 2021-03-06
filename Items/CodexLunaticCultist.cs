using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexLunaticCultist : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Lunatic Cultist");
            Tooltip.SetDefault("He's the reason why... Why the old man was cursed, why those machines were built." +
                               "\nI thought you killing him and his acolytes would prevent catastophe, but it seems" +
                               "\nto have only made the situation dire. Celestial beings are descending from the" +
                               "\nheavens and the earth itself is coalescing into vast pillars of cosmic power. I" +
                               "\nfear there may be impending doom upon us.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = 7;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.CultistBoss)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexLunaticCultist"));
                }
            }
        }
    }
}