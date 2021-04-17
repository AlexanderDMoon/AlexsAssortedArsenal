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
    public class AAAGlobalItem : GlobalItem
    {
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.Torch, 10);
            recipe.AddIngredient(ItemID.Daybloom, 3);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WandofSparking);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrystilianShard", 25);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddIngredient(ItemID.TeleportationPotion, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.RodofDiscord);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Copper or Tin Bar", 3);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Iron or Lead Bar", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.Aglet);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather, 8);
            recipe.AddIngredient(mod, "AquaticExplorerPotion", 3);
            recipe.AddIngredient(ItemID.Coral, 3);
            recipe.AddIngredient(ItemID.Seashell, 3);
            recipe.AddIngredient(ItemID.Starfish, 3);
            recipe.AddTile(TileID.CrystalBall);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WaterWalkingBoots);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Obsidian, 50);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.LavaBucket, 5);
            recipe.AddIngredient(ItemID.ObsidianSkinPotion, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(ItemID.LavaCharm);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BunnyPelt", 6);
            recipe.AddIngredient(ItemID.Silk, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.BunnyHood);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Minishark, 1);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 15);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.Uzi);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver);
            recipe.AddIngredient(ItemID.SoulofLight, 8);
            recipe.AddIngredient(ItemID.SoulofNight, 8);
            recipe.AddIngredient(ItemID.HallowedBar, 12);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.MagicQuiver);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BandofBloodletting", 1);
            recipe.AddIngredient(ItemID.BandofRegeneration, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(ItemID.ManaRegenerationBand);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 100);
            recipe.AddIngredient(ItemID.Gel, 75);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Copper or Tin Bar", 15);
            recipe.AddIngredient(ItemID.FallenStar, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeStaff);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddIngredient(mod, "Aquatana", 1);
            recipe.AddIngredient(ItemID.BladeofGrass, 1);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.NightsEdge);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BloodButcherer, 1);
            recipe.AddIngredient(mod, "Aquatana", 1);
            recipe.AddIngredient(ItemID.BladeofGrass, 1);
            recipe.AddIngredient(ItemID.FieryGreatsword, 1);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(ItemID.NightsEdge);
            recipe.AddRecipe();
        }    
    }
}