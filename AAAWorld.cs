using AlexsAssortedArsenal.Items;
using AlexsAssortedArsenal.NPCs;
using AlexsAssortedArsenal.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal
{
    public class AAAWorld : ModWorld
    {
        public override void PostWorldGen()
        {
            int[] itemsToPlaceInSkyChests = { ItemType<Galestrike>(), ItemType<BoomEcho>()};
            int itemsToPlaceInSkyChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];              
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 13 * 36)
                {

                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInSkyChests[itemsToPlaceInSkyChestsChoice]);
                            itemsToPlaceInSkyChestsChoice = (itemsToPlaceInSkyChestsChoice + 1) % itemsToPlaceInSkyChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInSkyChests));
                            break;
                        }
                    }
                }
            }

            int[] itemsToPlaceInLockedShadowChests = { ItemType<Hellbreaker>(), ItemType<MoltenCharm>(), ItemType<Scatterscorch>(), ItemType<ObsidianAmulet>(), ItemType<Firestar>()};
            int itemsToPlaceInLockedShadowChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 4 * 36)
                {

                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedShadowChests[itemsToPlaceInLockedShadowChestsChoice]);
                            itemsToPlaceInLockedShadowChestsChoice = (itemsToPlaceInLockedShadowChestsChoice + 1) % itemsToPlaceInLockedShadowChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInLockedShadowChests));
                            break;
                        }
                    }
                }
            }

            int[] itemsToPlaceInOceanChests = { ItemType<Privateer>(), ItemType<BubbleTrident>() };
            int itemsToPlaceInOceanChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 17 * 36)
                {

                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInOceanChests[itemsToPlaceInOceanChestsChoice]);
                            itemsToPlaceInOceanChestsChoice = (itemsToPlaceInOceanChestsChoice + 1) % itemsToPlaceInOceanChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInOceanChests));
                            break;
                        }
                    }
                }
            }

            int[] itemsToPlaceInLockedGoldChests = { ItemType<DungeonChakram>(), ItemType<SapphireHorn>() };
            int itemsToPlaceInLockedGoldChestsChoice = 0;
            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36)
                {

                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == 0)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedGoldChests[itemsToPlaceInLockedGoldChestsChoice]);
                            itemsToPlaceInLockedGoldChestsChoice = (itemsToPlaceInLockedGoldChestsChoice + 1) % itemsToPlaceInLockedGoldChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInLockedGoldChests));
                            break;
                        }
                    }
                }
            }
        }
    }
}