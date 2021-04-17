using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CodexMoonLord : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Codex: The Moon Lord");
            Tooltip.SetDefault("Hastur, one of the brothers of Cthulhu. I've only heard of myths surrounding him. I always" +
                               "\nthought in the back of my mind that he may have been real, but I always dismissed him" +
                               "\nas just that- a thought. But upon the destruction of the Lunar Pillars, he arrived in this" +
                               "\nworld hellbent on destruction and revenge, only to be cut down by you. But I have no time" +
                               "\nto give you praise... Hastur's existance in this universe has many, many nasty implications." +
                               "\nCthulhu exists, and so does his brother Kthanid. If these massive, eldritch beasts exist" +
                               "\nwithin our universe, then what else lurks out there between the stars? I'm afraid we can" +
                               "\nonly asks questions, and whether or not we get answers depends on the willingness of" +
                               "\nthe universe itself. It's confusing, I know... but the universe has no obligation to make" +
                               "\nsense to any of us.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 75, 0, 0);
            item.rare = 9;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.MoonLordCore)
                {
                    if (Main.rand.Next(30) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("CodexMoonLord"));
                }
            }
        }
    }
}