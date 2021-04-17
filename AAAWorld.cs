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
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Penumbrite", AAAOres));
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Aquamarine", AAAOres));
            }
        }

        private void AAAOres(GenerationProgress progress)
        {
            progress.Message = "Adding more shinies...";

            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), ModContent.TileType<Ore_Penumbrite>());
            }

            for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
            {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY);
                WorldGen.TileRunner(x, y, WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), ModContent.TileType<Ore_Aquamarine>());
            }

        }

        public override void PostWorldGen()
        {
            int[] itemsToPlaceInSkyChests = {ItemType<Galestrike>(), ItemType<BoomEcho>()};
            int[] itemsToPlaceInLockedShadowChests = { ItemType<Hellbreaker>(), ItemType<MoltenCharm>(), ItemType<Scatterscorch>(), ItemType<ObsidianAmulet>(), ItemType<Firestar>() };
            int[] itemsToPlaceInOceanChests = { ItemType<Privateer>(), ItemType<BubbleTrident>() };
            int[] itemsToPlaceInLockedGoldChests = { ItemType<DungeonChakram>(), ItemType<SapphireHorn>(), ItemType<AncientWeaponComponent>() };
            int[] itemsToPlaceInLockedHallowedChests = { ItemType<FairiumCrate>() };
            int itemsToPlaceInSkyChestsChoice = 0;
            int itemsToPlaceInLockedShadowChestsChoice = 0;
            int itemsToPlaceInOceanChestsChoice = 0;
            int itemsToPlaceInLockedGoldChestsChoice = 0;
            int itemsToPlaceInLockedHallowedChestsChoice = 0;

            for (int chestIndex = 0; chestIndex < 1000; chestIndex++)
            {
                Chest chest = Main.chest[chestIndex];              
                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 13 * 36) //Sky
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInSkyChests[itemsToPlaceInSkyChestsChoice]);
                            itemsToPlaceInSkyChestsChoice = (itemsToPlaceInSkyChestsChoice + 1) % itemsToPlaceInSkyChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInSkyChests));
                            break;
                        }
                    }
                }

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 4 * 36) //Shadow
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedShadowChests[itemsToPlaceInLockedShadowChestsChoice]);
                            itemsToPlaceInLockedShadowChestsChoice = (itemsToPlaceInLockedShadowChestsChoice + 1) % itemsToPlaceInLockedShadowChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInLockedShadowChests));
                            break;
                        }
                    }
                }

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 17 * 36) //Water
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInOceanChests[itemsToPlaceInOceanChestsChoice]);
                            itemsToPlaceInOceanChestsChoice = (itemsToPlaceInOceanChestsChoice + 1) % itemsToPlaceInOceanChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInOceanChests));
                            break;
                        }
                    }
                }

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 2 * 36) //Locked Gold
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {

                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedGoldChests[itemsToPlaceInLockedGoldChestsChoice]);
                            itemsToPlaceInLockedGoldChestsChoice = (itemsToPlaceInLockedGoldChestsChoice + 1) % itemsToPlaceInLockedGoldChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInLockedGoldChests));
                            break;
                        }
                    }
                }

                if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 26 * 36) //Locked Hallowed
                {
                    for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++)
                    {
                        if (chest.item[inventoryIndex].type == ItemID.None)
                        {
                            chest.item[inventoryIndex].SetDefaults(itemsToPlaceInLockedHallowedChests[itemsToPlaceInLockedHallowedChestsChoice]);
                            itemsToPlaceInLockedHallowedChestsChoice = (itemsToPlaceInLockedHallowedChestsChoice + 1) % itemsToPlaceInLockedHallowedChests.Length;
                            chest.item[inventoryIndex].SetDefaults(Main.rand.Next(itemsToPlaceInLockedHallowedChests));
                            break;
                        }
                    }
                }
            }
        }
    }
}