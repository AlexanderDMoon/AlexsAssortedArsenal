using Terraria;
using Microsoft.Xna.Framework;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using AlexsAssortedArsenal.Items;

namespace AlexsAssortedArsenal
{
    public class AAAGlobalTile : GlobalTile
    {
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockCopper>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(1, 9));

                    if (Main.rand.Next(20) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(20) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TinOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(40) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(40) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(120) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(120) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockCopperAmethyst>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(1, 12));

                    if (Main.rand.Next(17) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(17) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TinOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(37) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(37) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(115) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(115) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockTin>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(1, 9));

                    if (Main.rand.Next(20) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(20) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TinOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(40) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(40) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(120) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(120) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockTinTopaz>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(1, 12));

                    if (Main.rand.Next(17) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(17) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TinOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(37) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(37) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(115) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(115) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockGold>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(9, 21));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockGoldRuby>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(2, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(2, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockPlatinum>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(9, 21));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(1, 3));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockPlatinumDiamond>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(10) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.IronOre, Main.rand.Next(2, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.LeadOre, Main.rand.Next(2, 3));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(2, 4));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 2));

                    if (Main.rand.Next(170) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockDemonite>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(1));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(1));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.DemoniteOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CrimtaneOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 3));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockDemoniteShadowscale>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(185) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.DemoniteOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(185) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CrimtaneOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 3));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.ShadowScale, Main.rand.Next(1));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockCrimtane>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(1));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(1));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(60) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.DemoniteOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CrimtaneOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 3));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 3));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockCrimtaneCrimson>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(185) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.DemoniteOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(185) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CrimtaneOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1, 3));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1, 3));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TissueSample, Main.rand.Next(1));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockMolten>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 25));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.DemoniteOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CrimtaneOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Hellstone, Main.rand.Next(1, 2));

                    if (Main.rand.Next(180) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Obsidian, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockDungeon>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(9, 15));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Aquamarine"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), mod.ItemType("Penumbrite"), Main.rand.Next(1, 3));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1));

                    if (Main.rand.Next(150) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Bone, Main.rand.Next(1, 4));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockJungle>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(9, 15));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.SilverOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TungstenOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1));

                    if (Main.rand.Next(55) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amethyst, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Topaz, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1));

                    if (Main.rand.Next(190) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1));

                    if (Main.rand.Next(150) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.JungleSpores, Main.rand.Next(1, 4));

                    if (Main.rand.Next(150) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Vine, Main.rand.Next(1));

                    if (Main.rand.Next(150) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Stinger, Main.rand.Next(1, 2));
                }
            }

            if (Main.LocalPlayer.HeldItem.type == ModContent.ItemType<MattockFairium>())
            {
                if (type == TileID.Silt || type == TileID.Slush || type == TileID.DesertFossil)
                {
                    if (Main.rand.Next(15) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CopperCoin, Main.rand.Next(12, 17));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.GoldOre, Main.rand.Next(1));

                    if (Main.rand.Next(45) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PlatinumOre, Main.rand.Next(1));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Amber, Main.rand.Next(1));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Sapphire, Main.rand.Next(1, 2));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Emerald, Main.rand.Next(1, 2));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Ruby, Main.rand.Next(1));

                    if (Main.rand.Next(175) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.Diamond, Main.rand.Next(1));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.CobaltOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(200) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.PalladiumOre, Main.rand.Next(1, 2));

                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.MythrilOre, Main.rand.Next(1));

                    if (Main.rand.Next(225) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.OrichalcumOre, Main.rand.Next(1));

                    if (Main.rand.Next(250) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.AdamantiteOre, Main.rand.Next(1));

                    if (Main.rand.Next(250) == 0)
                        Item.NewItem(new Vector2(i * 16, j * 16), ItemID.TitaniumOre, Main.rand.Next(1));
                }
            }
        }
    }
}