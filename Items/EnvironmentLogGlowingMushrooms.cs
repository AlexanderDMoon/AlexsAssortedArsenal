using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogGlowingMushrooms : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: Glowing Mushroom Grove");
            Tooltip.SetDefault("After having layed on my bed, comatose and drooling all over my sheets for several hours, I can" +
                               "\nsay that eating several of the mushrooms found in underground groves all at once is not recommended," +
                               "\neven if you're starving. Seriously, there's no benefit to it; You just lay there braindead for a" +
                               "\nfew hours. Not really much enjoyment in that. BUT, I've discovered that these can be used to make" +
                               "\nstronger healing potions! At least something came out of that rather dull experience, right?");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 4;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.FungiBulb)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }

                if (npc.type == NPCID.ZombieMushroomHat)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }

                if (npc.type == NPCID.ZombieMushroom)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }

                if (npc.type == NPCID.AnomuraFungus)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }

                if (npc.type == NPCID.GiantFungiBulb)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }

                if (npc.type == NPCID.FungoFish)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogGlowingMushrooms"));
                }
            }
        }
    }
}