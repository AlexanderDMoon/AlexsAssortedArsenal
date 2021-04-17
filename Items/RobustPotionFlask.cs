using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class RobustPotionFlask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Robust Potion Flask");
            Tooltip.SetDefault("'Seems like it can contain some of the more volatile mixtures.'");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 44;
            item.value = Item.sellPrice(0, 0, 15, 0);
            item.rare = 4;
            item.maxStack = 999;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Retinazer)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(1, 3));
                }

                if (npc.type == NPCID.Spazmatism)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(1, 3));
                }

                if (npc.type == NPCID.SkeletronPrime)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(3, 5));
                }

                if (npc.type == NPCID.TheDestroyer)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(3, 5));
                }

                if (npc.type == NPCID.TheDestroyerTail)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(3, 5));
                }

                if (npc.type == NPCID.TheDestroyerBody)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("RobustPotionFlask"), Main.rand.Next(3, 5));
                }
            }
        }
    }
}