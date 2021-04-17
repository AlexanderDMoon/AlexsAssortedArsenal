using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogHallow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Hallow");
            Tooltip.SetDefault("Oh, such wonderful whimsy! Upon my return to the surface, I found the bright cyan grasses and" +
                               "\nmulti-colored trees of the Hallow spreading across the land. As amazing as this place is, however," +
                               "\nI question its... motives, so to speak. It seems almost like the World Evil in nature, spreading with" +
                               "\nunknown intent after the destruction of that underworld horror. You must remain wary of all of it.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 6;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Pixie)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }

                if (npc.type == NPCID.Unicorn)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }

                if (npc.type == NPCID.RainbowSlime)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }

                if (npc.type == NPCID.Gastropod)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }

                if (npc.type == NPCID.LightMummy)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }

                if (npc.type == NPCID.DesertGhoulHallow)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogHallow"));
                }
            }
        }
    }
}