using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class SoulofThrills : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Thrills");
            Tooltip.SetDefault("'A ghastly chill pierces your spine as you touch this.'");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
            ItemID.Sets.AnimatesAsSoul[item.type] = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.value = Item.sellPrice(0, 0, 85, 0);
            item.rare = 6;
            item.maxStack = 999;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.MourningWood)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("SoulofThrills"), Main.rand.Next(1, 3));
                }

                if (npc.type == NPCID.HeadlessHorseman)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("SoulofThrills"), Main.rand.Next(1, 3));
                }

                if (npc.type == NPCID.Pumpking)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("SoulofThrills"), Main.rand.Next(6, 12));
                }
            }
        }
    }
}