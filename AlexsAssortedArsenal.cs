using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace AlexsAssortedArsenal
{
    class AlexsAssortedArsenal : Mod
    {
        public AlexsAssortedArsenal()
        {
            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerNebula");
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerSolar");
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerStardust");
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerVortex");

            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("AmethystBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("TopazBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("SapphireBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("EmeraldBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("RubyBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("DiamondBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("AmberBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("AquamarineBullet");
            AlexsAssortedArsenal.Instance.ProjectileType("PenumbriteBullet");

            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("PurpleStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("YellowStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("BlueStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("GreenStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("RedStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("WhiteStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("AquamarineStarblast");
            AlexsAssortedArsenal.Instance.ProjectileType("PenumbriteStarblast");

            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityNebula");
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocitySolar");
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityStardust");
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityVortex");

            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAmethyst");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamTopaz");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamSapphire");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamEmerald");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamRuby");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamDiamond");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAmber");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamAquamarine");
            AlexsAssortedArsenal.Instance.ProjectileType("SwordBeamPenumbrite");

            Instance = this;
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkCorruption");
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkCrimson");
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkHallow");
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkJungle");
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkOcean");
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkSnow");
        }

        public override void Load()
        {
            Items.Accessories.Movement.CloakHook.Load();
        }

        public static AlexsAssortedArsenal Instance { get; private set; }

        //------------------RECIPE GROUPS------------------
        public override void AddRecipeGroups()
        {
            RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + " Star Striker", new int[]
            {
                            ItemType("BlueStarStriker"),
                            ItemType("GreenStarStriker"),
                            ItemType("RedStarStriker"),
                            ItemType("PurpleStarStriker"),
                            ItemType("WhiteStarStriker"),
                            ItemType("YellowStarStriker"),
                            ItemType("AquamarineStarStriker"),
                            ItemType("AmberStarStriker")
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Star Striker", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Copper or Tin", new int[]
            {
                            ItemID.CopperBar,
                            ItemID.TinBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Copper or Tin Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Iron or Lead Bar", new int[]
            {
                            ItemID.IronBar,
                            ItemID.LeadBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Iron or Lead Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Silver or Tungsten", new int[]
            {
                            ItemID.SilverBar,
                            ItemID.TungstenBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Silver or Tungsten Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum", new int[]
            {
                            ItemID.GoldBar,
                            ItemID.PlatinumBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Demonite or Crimtane Bar", new int[]
            {
                            ItemID.DemoniteBar,
                            ItemID.CrimtaneBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Demonite or Crimtane Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Cobalt or Palladium Bar", new int[]
            {
                            ItemID.CobaltBar,
                            ItemID.PalladiumBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Cobalt or Palladium Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Mythril or Orichaclum Bar", new int[]
            {
                            ItemID.MythrilBar,
                            ItemID.OrichalcumBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Mythril or Orichalcum Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Adamantite or Titanium Bar", new int[]
            {
                            ItemID.AdamantiteBar,
                            ItemID.TitaniumBar,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Adamantite or Titanium Bar", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Adamantite or Titanium Forge", new int[]
            {
                            ItemID.AdamantiteForge,
                            ItemID.TitaniumForge,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Adamantite or Titanium Forge", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum Pickaxe", new int[]
            {
                            ItemID.GoldPickaxe,
                            ItemID.PlatinumPickaxe,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Pickaxe", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Shadow Scales or Tissue Samples", new int[]
            {
                            ItemID.ShadowScale,
                            ItemID.TissueSample,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Shadow Scales or Tissue Samples", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Hallowed Headpiece", new int[]
            {
                            ItemID.HallowedHeadgear,
                            ItemID.HallowedHelmet,
                            ItemID.HallowedMask,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Hallowed Headpiece", group);

            group = new RecipeGroup(() => Lang.misc[37] + " GeMP-44", new int[]
            {
                            ItemType("GeMP44AC"),
                            ItemType("GeMP44TT"),
                            ItemType("GeMP44AI"),
                            ItemType("GeMP44PL"),
                            ItemType("GeMP44SS"),
                            ItemType("GeMP44ET"),
                            ItemType("GeMP44RG"),
                            ItemType("GeMP44DP"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Any GeMP-44", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Metal Staff", new int[]
            {
                            ItemID.AmethystStaff,
                            ItemID.TopazStaff,
                            ItemType("IronStaff"),
                            ItemType("LeadStaff"),
                            ItemID.SapphireStaff,
                            ItemID.EmeraldStaff,
                            ItemID.RubyStaff,
                            ItemID.DiamondStaff,
                            ItemID.AmberStaff,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Any Metal Staff", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Metalligem Greatsword", new int []
            {
                            ItemType("CopperMetalligemGreatsword"),
                            ItemType("TinMetalligemGreatsword"),
                            ItemType("IronMetalligemGreatsword"),
                            ItemType("LeadMetalligemGreatsword"),
                            ItemType("SilverMetalligemGreatsword"),
                            ItemType("TungstenMetalligemGreatsword"),
                            ItemType("GoldMetalligemGreatsword"),
                            ItemType("PlatinumMetalligemGreatsword"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Any Metalligem Greatsword", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Adamantite or Titanium Statusblade", new int[]
            {
                            ItemType("AdamantiteStatusblade"),
                            ItemType("TitaniumStatusblade"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Adamantite or Titanium Statusblade", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Lunar Pickaxe", new int[]
            {
                            ItemID.SolarFlarePickaxe,
                            ItemID.StardustPickaxe,
                            ItemID.NebulaPickaxe,
                            ItemID.VortexPickaxe,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Lunar Pickaxe", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Lunar Hamaxe", new int[]
            {
                            ItemID.LunarHamaxeSolar,
                            ItemID.LunarHamaxeStardust,
                            ItemID.LunarHamaxeNebula,
                            ItemID.LunarHamaxeVortex,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Lunar Hamaxe", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Mythril or Orichalcum Anvil", new int[]
            {
                            ItemID.MythrilAnvil,
                            ItemID.OrichalcumAnvil,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Mythril or Orichalcum Anvil", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Light's Bane or Blood Butcherer", new int[]
            {
                            ItemID.LightsBane,
                            ItemID.BloodButcherer,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Light's Bane or Blood Butcherer", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Vilethorn or Crimson Rod", new int[]
            {
                            ItemID.Vilethorn,
                            ItemID.CrimsonRod,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Vilethorn or Crimson Rod", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Musket or Undertaker", new int[]
            {
                            ItemID.Musket,
                            ItemID.TheUndertaker,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Musket or Undertaker", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Adamantite or Titanium Musket", new int[]
            {
                            ItemType("AdamantiteMusket"),
                            ItemType("TitaniumMusket"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Adamantite or Titanium Musket", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum Drill", new int[]
            {
                            ItemType("MiningDrillGold"),
                            ItemType("MiningDrillPlatinum"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Drill", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Blightspark or Bloodspark Wand", new int[]
            {
                            ItemType("SparkWandCorruption"),
                            ItemType("SparkWandCrimson"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Blightspark or Bloodspark Wand", group);

            group = new RecipeGroup(() => Lang.misc[37] + " M1 Gangarand, FN-FLAY, OR Cryo Driver", new int[]
            {
                            ItemType("M1Gangarand"),
                            ItemType("FNFLAY"),
                            ItemType("CryoDriver"),
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:M1 Gangarand, FN-FLAY, or Cryo Driver", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Lightning Bugs or Fireflies", new int[]
            {
                            ItemID.LightningBug,
                            ItemID.Firefly,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Lightning Bugs or Fireflies", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum Helmet", new int[]
            {
                            ItemID.AncientGoldHelmet,
                            ItemID.GoldHelmet,
                            ItemID.PlatinumHelmet,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Helmet", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum Chestpiece", new int[]
            {
                            ItemID.GoldChainmail,
                            ItemID.PlatinumChainmail,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Chestpiece", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Gold or Platinum Greaves", new int[]
            {
                            ItemID.GoldGreaves,
                            ItemID.PlatinumGreaves,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Gold or Platinum Greaves", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Shadowscale or Crimson Chestpiece", new int[]
            {
                            ItemID.ShadowScalemail,
                            ItemID.AncientShadowScalemail,
                            ItemID.CrimsonChest,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Shadowscale or Crimson Chestpiece", group);

            group = new RecipeGroup(() => Lang.misc[37] + " Magic Mirror or Ice Mirror", new int[]
            {
                            ItemID.MagicMirror,
                            ItemID.IceMirror,
            });
            RecipeGroup.RegisterGroup("AlexsAssortedArsenal:Magic Mirror or Ice Mirror", group);
        }
    }
}

namespace AlexsAssortedArsenal.Tiles
{
    //------------------UTILITY AND DECORATION TILES------------------

    public class PeacekeeperWorkbench : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            ModTranslation name = CreateMapEntryName("Peacekeeper Workbench");
            AddMapEntry(new Color(500, 500, 500), name);
            dustType = mod.DustType("Sparkle");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.WorkBenches };
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("PeacekeeperWorkbench"));
        }
    }

    public class PeacekeeperAnvil : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName("Peacekeeper Anvil");
            AddMapEntry(new Color(500, 500, 500), name);
            dustType = mod.DustType("Sparkle");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Anvils, TileID.MythrilAnvil };
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("PeacekeeperAnvil"));
        }
    }

    public class PeacekeeperForge : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName("Peacekeeper Forge");
            AddMapEntry(new Color(500, 500, 500), name);
            dustType = mod.DustType("Sparkle");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.AdamantiteForge, TileID.Furnaces, TileID.Hellforge };
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("PeacekeeperForge"));
        }
    }

    public class AetheriumBrick : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 250;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMerge[ModContent.TileType<AetheriumBrick>()][ModContent.TileType<AetheriumPaneling>()] = true;
            drop = mod.ItemType("AetheriumBrick");
            AddMapEntry(new Color(200, 200, 200));
        }
    }

    public class AetheriumBrickWeathered : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 250;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMerge[ModContent.TileType<AetheriumBrick>()][ModContent.TileType<AetheriumPaneling>()] = true;
            drop = mod.ItemType("AetheriumBrickWeathered");
            AddMapEntry(new Color(165, 140, 165));
        }
    }

    public class AetheriumBrickWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            drop = mod.ItemType("AetheriumBrickWall");
            AddMapEntry(new Color(125, 125, 125));
        }
    }

    public class AetheriumBrickWallWeathered : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            drop = mod.ItemType("AetheriumBrickWallWeathered");
            AddMapEntry(new Color(80, 65, 80));
        }
    }

    public class AetheriumPaneling : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 245;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            Main.tileMerge[ModContent.TileType<AetheriumPaneling>()][ModContent.TileType<AetheriumBrick>()] = true;
            drop = mod.ItemType("AetheriumPaneling");
            AddMapEntry(new Color(200, 200, 200));
        }
    }

    public class AetheriumPlatform : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 250;
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.AetheriumPlatform>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(200, 200, 200));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformDiamond : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformDiamond>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(240, 240, 247));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(240, 240, 247) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }
    
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformAmethyst : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformAmethyst>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(221, 79, 255));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(221, 79, 225) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformTopaz : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformTopaz>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(250, 225, 79));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(250, 225, 79) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformSapphire : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformSapphire>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(79, 102, 255));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(79, 102, 255) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformEmerald : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformEmerald>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(79, 255, 89));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(79, 225, 89) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformRuby : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformRuby>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(255, 79, 79));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(255, 79, 79) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    public class GemsparkPlatformAmber : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileSolid[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileID.Sets.Platforms[Type] = true;
            TileObjectData.newTile.CoordinateHeights = new[] { 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 27;
            TileObjectData.newTile.StyleWrapLimit = 27;
            TileObjectData.newTile.UsesCustomCanPlace = false;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);
            drop = ModContent.ItemType<Items.Placeable.GemsparkPlatformAmber>();
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsDoor);
            AddMapEntry(new Color(255, 145, 79));
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Platforms };
        }

        public override void DrawEffects(int i, int j, SpriteBatch spriteBatch, ref Color drawColor, ref int nextSpecialDrawIndex)
        {
            Lighting.AddLight(new Vector2(i * 16, j * 16), new Vector3(255, 145, 79) * 0.0037f);
        }

        public override void PostSetDefaults()
        {
            Main.tileNoSunLight[Type] = false;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }

    //public class FairiumBrick : ModTile
    //{
    //   public override void SetDefaults()
    //    {
    //        Main.tileSolid[Type] = true;
    //        Main.tileMergeDirt[Type] = true;
    //        Main.tileBlockLight[Type] = true;
    //        Main.tileLighted[Type] = true;
    //        drop = mod.ItemType("FairiumBrick");
    //        AddMapEntry(new Color(0, 0, 0));
    //    }
    //}

    public class FairiumTable : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            ModTranslation name = CreateMapEntryName("Fairium Table");
            AddMapEntry(new Color(198, 134, 76), name);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Tables };
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("FairiumTable"));
        }
    }

    public class AetheriumTable : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = true;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            ModTranslation name = CreateMapEntryName("Aetherium Table");
            AddMapEntry(new Color(0, 0, 0), name);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Tables };
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("AetheriumTable"));
        }
    }

    public class FairiumChair : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
            TileObjectData.newTile.StyleWrapLimit = 2; 
            TileObjectData.newTile.StyleMultiplier = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1); 
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsChair);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Fairium Chair");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Chairs };
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("FairiumChair"));
        }
    }

    public class AetheriumChair : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2);
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
            TileObjectData.newTile.StyleWrapLimit = 2;
            TileObjectData.newTile.StyleMultiplier = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);
            TileObjectData.addTile(Type);
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsChair);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Aetherium Chair");
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Chairs };
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("AetheriumChair"));
        }
    }

    public class FairiumChest : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSpelunker[Type] = true;
            Main.tileContainer[Type] = true;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 1200;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileValue[Type] = 500;
            TileID.Sets.HasOutlines[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 18 };
            TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
            TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
            TileObjectData.newTile.AnchorInvalidTiles = new int[] { 127 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Fairium Chest");
            AddMapEntry(new Color(200, 200, 200), name, MapChestName);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Containers };
            chest = "Fairium Chest";
            chestDrop = mod.ItemType("FairiumChest");
        }

        public override bool HasSmartInteract()
        {
            return true;
        }

        public string MapChestName(string name, int i, int j)
        {
            int left = i;
            int top = j;
            Tile tile = Main.tile[i, j];
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            if (Main.chest[chest].name == "")
            {
                return name;
            }
            else
            {
                return name + ": " + Main.chest[chest].name;
            }
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 1;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 32, chestDrop);
            Chest.DestroyChest(i, j);
        }

        public override void RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            Main.mouseRightRelease = false;
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            if (player.sign >= 0)
            {
                Main.PlaySound(SoundID.MenuClose);
                player.sign = -1;
                Main.editSign = false;
                Main.npcChatText = "";
            }
            if (Main.editChest)
            {
                Main.PlaySound(SoundID.MenuTick);
                Main.editChest = false;
                Main.npcChatText = "";
            }
            if (player.editedChestName)
            {
                NetMessage.SendData(33, -1, -1, NetworkText.FromLiteral(Main.chest[player.chest].name), player.chest, 1f, 0f, 0f, 0, 0, 0);
                player.editedChestName = false;
            }
            if (Main.netMode == 1)
            {
                if (left == player.chestX && top == player.chestY && player.chest >= 0)
                {
                    player.chest = -1;
                    Recipe.FindRecipes();
                    Main.PlaySound(SoundID.MenuClose);
                }
                else
                {
                    NetMessage.SendData(31, -1, -1, null, left, (float)top, 0f, 0f, 0, 0, 0);
                    Main.stackSplit = 600;
                }
            }
            else
            {
                int chest = Chest.FindChest(left, top);
                if (chest >= 0)
                {
                    Main.stackSplit = 600;
                    if (chest == player.chest)
                    {
                        player.chest = -1;
                        Main.PlaySound(SoundID.MenuClose);
                    }
                    else
                    {
                        player.chest = chest;
                        Main.playerInventory = true;
                        Main.recBigList = false;
                        player.chestX = left;
                        player.chestY = top;
                        Main.PlaySound(player.chest < 0 ? SoundID.MenuOpen : SoundID.MenuTick);
                    }
                    Recipe.FindRecipes();
                }
            }
        }



        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            player.showItemIcon2 = -1;
            if (chest < 0)
            {
                player.showItemIconText = Language.GetTextValue("LegacyChestType.0");
            }
            else
            {
                player.showItemIconText = Main.chest[chest].name.Length > 0 ? Main.chest[chest].name : "Fairium Chest";
                if (player.showItemIconText == "Fairium Chest")
                {
                    player.showItemIcon2 = mod.ItemType("FairiumChest");
                    player.showItemIconText = "";
                }
            }
            player.noThrow = 2;
            player.showItemIcon = true;
        }

        public override void MouseOverFar(int i, int j)
        {
            MouseOver(i, j);
            Player player = Main.LocalPlayer;
            if (player.showItemIconText == "")
            {
                player.showItemIcon = false;
                player.showItemIcon2 = 0;
            }
        }
    }

    public class AetheriumChest : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSpelunker[Type] = true;
            Main.tileContainer[Type] = true;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 1200;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileValue[Type] = 500;
            TileID.Sets.HasOutlines[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 18 };
            TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
            TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
            TileObjectData.newTile.AnchorInvalidTiles = new int[] { 127 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Aetherium Chest");
            AddMapEntry(new Color(200, 200, 200), name, MapChestName);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Containers };
            chest = "Aetherium Chest";
            chestDrop = mod.ItemType("AetheriumChest");
        }

        public override bool HasSmartInteract()
        {
            return true;
        }

        public string MapChestName(string name, int i, int j)
        {
            int left = i;
            int top = j;
            Tile tile = Main.tile[i, j];
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            if (Main.chest[chest].name == "")
            {
                return name;
            }
            else
            {
                return name + ": " + Main.chest[chest].name;
            }
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 1;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 32, chestDrop);
            Chest.DestroyChest(i, j);
        }

        public override void RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            Main.mouseRightRelease = false;
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            if (player.sign >= 0)
            {
                Main.PlaySound(SoundID.MenuClose);
                player.sign = -1;
                Main.editSign = false;
                Main.npcChatText = "";
            }
            if (Main.editChest)
            {
                Main.PlaySound(SoundID.MenuTick);
                Main.editChest = false;
                Main.npcChatText = "";
            }
            if (player.editedChestName)
            {
                NetMessage.SendData(33, -1, -1, NetworkText.FromLiteral(Main.chest[player.chest].name), player.chest, 1f, 0f, 0f, 0, 0, 0);
                player.editedChestName = false;
            }
            if (Main.netMode == 1)
            {
                if (left == player.chestX && top == player.chestY && player.chest >= 0)
                {
                    player.chest = -1;
                    Recipe.FindRecipes();
                    Main.PlaySound(SoundID.MenuClose);
                }
                else
                {
                    NetMessage.SendData(31, -1, -1, null, left, (float)top, 0f, 0f, 0, 0, 0);
                    Main.stackSplit = 600;
                }
            }
            else
            {
                int chest = Chest.FindChest(left, top);
                if (chest >= 0)
                {
                    Main.stackSplit = 600;
                    if (chest == player.chest)
                    {
                        player.chest = -1;
                        Main.PlaySound(SoundID.MenuClose);
                    }
                    else
                    {
                        player.chest = chest;
                        Main.playerInventory = true;
                        Main.recBigList = false;
                        player.chestX = left;
                        player.chestY = top;
                        Main.PlaySound(player.chest < 0 ? SoundID.MenuOpen : SoundID.MenuTick);
                    }
                    Recipe.FindRecipes();
                }
            }
        }



        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            player.showItemIcon2 = -1;
            if (chest < 0)
            {
                player.showItemIconText = Language.GetTextValue("LegacyChestType.0");
            }
            else
            {
                player.showItemIconText = Main.chest[chest].name.Length > 0 ? Main.chest[chest].name : "Aetherium Chest";
                if (player.showItemIconText == "Aetherium Chest")
                {
                    player.showItemIcon2 = mod.ItemType("AetheriumChest");
                    player.showItemIconText = "";
                }
            }
            player.noThrow = 2;
            player.showItemIcon = true;
        }

        public override void MouseOverFar(int i, int j)
        {
            MouseOver(i, j);
            Player player = Main.LocalPlayer;
            if (player.showItemIconText == "")
            {
                player.showItemIcon = false;
                player.showItemIcon2 = 0;
            }
        }
    }

    public class AetheriumFootlocker : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSpelunker[Type] = true;
            Main.tileContainer[Type] = true;
            Main.tileShine2[Type] = true;
            Main.tileShine[Type] = 1200;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileValue[Type] = 500;
            TileID.Sets.HasOutlines[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 18 };
            TileObjectData.newTile.HookCheck = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.FindEmptyChest), -1, 0, true);
            TileObjectData.newTile.HookPostPlaceMyPlayer = new PlacementHook(new Func<int, int, int, int, int, int>(Chest.AfterPlacement_Hook), -1, 0, false);
            TileObjectData.newTile.AnchorInvalidTiles = new int[] { 127 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide, TileObjectData.newTile.Width, 0);
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Aetherium Footlocker");
            AddMapEntry(new Color(200, 200, 200), name, MapChestName);
            disableSmartCursor = true;
            adjTiles = new int[] { TileID.Containers };
            chest = "Aetherium Footlocker";
            chestDrop = mod.ItemType("AetheriumFootlocker");
        }

        public override bool HasSmartInteract()
        {
            return true;
        }

        public string MapChestName(string name, int i, int j)
        {
            int left = i;
            int top = j;
            Tile tile = Main.tile[i, j];
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            if (Main.chest[chest].name == "")
            {
                return name;
            }
            else
            {
                return name + ": " + Main.chest[chest].name;
            }
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = 1;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 32, chestDrop);
            Chest.DestroyChest(i, j);
        }

        public override void RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            Main.mouseRightRelease = false;
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            if (player.sign >= 0)
            {
                Main.PlaySound(SoundID.MenuClose);
                player.sign = -1;
                Main.editSign = false;
                Main.npcChatText = "";
            }
            if (Main.editChest)
            {
                Main.PlaySound(SoundID.MenuTick);
                Main.editChest = false;
                Main.npcChatText = "";
            }
            if (player.editedChestName)
            {
                NetMessage.SendData(33, -1, -1, NetworkText.FromLiteral(Main.chest[player.chest].name), player.chest, 1f, 0f, 0f, 0, 0, 0);
                player.editedChestName = false;
            }
            if (Main.netMode == 1)
            {
                if (left == player.chestX && top == player.chestY && player.chest >= 0)
                {
                    player.chest = -1;
                    Recipe.FindRecipes();
                    Main.PlaySound(SoundID.MenuClose);
                }
                else
                {
                    NetMessage.SendData(31, -1, -1, null, left, (float)top, 0f, 0f, 0, 0, 0);
                    Main.stackSplit = 600;
                }
            }
            else
            {
                int chest = Chest.FindChest(left, top);
                if (chest >= 0)
                {
                    Main.stackSplit = 600;
                    if (chest == player.chest)
                    {
                        player.chest = -1;
                        Main.PlaySound(SoundID.MenuClose);
                    }
                    else
                    {
                        player.chest = chest;
                        Main.playerInventory = true;
                        Main.recBigList = false;
                        player.chestX = left;
                        player.chestY = top;
                        Main.PlaySound(player.chest < 0 ? SoundID.MenuOpen : SoundID.MenuTick);
                    }
                    Recipe.FindRecipes();
                }
            }
        }



        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            Tile tile = Main.tile[i, j];
            int left = i;
            int top = j;
            if (tile.frameX % 36 != 0)
            {
                left--;
            }
            if (tile.frameY != 0)
            {
                top--;
            }
            int chest = Chest.FindChest(left, top);
            player.showItemIcon2 = -1;
            if (chest < 0)
            {
                player.showItemIconText = Language.GetTextValue("LegacyChestType.0");
            }
            else
            {
                player.showItemIconText = Main.chest[chest].name.Length > 0 ? Main.chest[chest].name : "Aetherium Footlocker";
                if (player.showItemIconText == "Aetherium Footlocker")
                {
                    player.showItemIcon2 = mod.ItemType("AetheriumFootlocker");
                    player.showItemIconText = "";
                }
            }
            player.noThrow = 2;
            player.showItemIcon = true;
        }

        public override void MouseOverFar(int i, int j)
        {
            MouseOver(i, j);
            Player player = Main.LocalPlayer;
            if (player.showItemIconText == "")
            {
                player.showItemIcon = false;
                player.showItemIcon2 = 0;
            }
        }
    }

    public class OfficeDesk : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileTable[Type] = false;
            Main.tileLavaDeath[Type] = false;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Width = 3;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName("Office Desk");
            AddMapEntry(new Color(500, 500, 500), name);
            disableSmartCursor = true;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("OfficeDesk"));
        }
    }


    public class Ore_Penumbrite : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 0;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            ModTranslation name = CreateMapEntryName("Penumbrite");
            drop = mod.ItemType("Penumbrite");
            AddMapEntry(new Color(61, 39, 124));
        }
    }

    public class Ore_Aquamarine : ModTile
    {
        public override void SetDefaults()
        {
            minPick = 0;
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlendAll[Type] = true;
            ModTranslation name = CreateMapEntryName("Aquamarine");
            drop = mod.ItemType("Aquamarine");
            AddMapEntry(new Color(37, 196, 193));
        }
    }

    namespace AlexsAssortedArsenal.Buffs
    {
        //------------------BUFFS AND DEBUFFS------------------
        public class Overclocked : ModBuff
        {

            public override void SetDefaults()
            {
                DisplayName.SetDefault("Overclocked");
                Description.SetDefault("Your power is doubled; Make it count!");
                Main.debuff[Type] = false;
                Main.buffNoSave[Type] = true;
                Main.buffNoTimeDisplay[Type] = false;
                canBeCleared = true;
            }

            public override void Update(Player player, ref int buffIndex)
            {
                player.allDamage *= 2;
                player.meleeCrit *= 2;
                player.meleeSpeed *= 2f;
                player.rangedCrit *= 2;
                player.magicCrit *= 2;
                player.statDefense += 20;
                player.moveSpeed += 0.15f;
                player.manaRegenBuff = true;
            }

            public class Mirrorback : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Mirrorback");
                    Description.SetDefault("Your sharp skin shines in the light. \nBroken-off fragments evaporate like some kind of magical glass.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.thorns = 1.25f;
                }
            }

            public class ManaCharged : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Mana Charged");
                    Description.SetDefault("Your magic efficiency is boosted.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.manaCost *= 0.8f;
                }
            }

            public class Slashed : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Slashed");
                    Description.SetDefault("Losing blood.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = false;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int BuffIndex)
                {
                    npc.lifeRegen = -25;
                }
            }

            public class Enchanted : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Enchanted");
                    Description.SetDefault("Life regen and defense are increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int BuffIndex)
                {
                    player.lifeRegen = 2;
                    player.statDefense += 2;
                }
            }

            public class EnchantmentOfMight : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Enchantment of Might");
                    Description.SetDefault("Life Regeneration Increased by 2. \nMovement speed increased by 6%. \nRanged Crit Chance increased by 4%.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int BuffIndex)
                {
                    player.lifeRegen = 2;
                    player.moveSpeed += 0.06f;
                    player.rangedCrit += 4;
                }
            }

            public class EnchantmentOfSight : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Enchantment of Sight");
                    Description.SetDefault("Life Regeneration increased by 2. \nDefense increased by 4. \nMana Efficiency increased by 7%.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int BuffIndex)
                {
                    player.lifeRegen = 2;
                    player.statDefense += 4;
                    player.manaCost *= 0.93f;
                }
            }

            public class EnchantmentOfFright : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Enchantment of Fright");
                    Description.SetDefault("Life Regeneration increased by 4. \nDefense increased by 6. \nMelee speed increased by 8%.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int BuffIndex)
                {
                    player.lifeRegen = 4;
                    player.statDefense += 6;
                    player.meleeSpeed += 0.08f;
                }
            }

            public class MetalSkin1 : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Metal Skin I");
                    Description.SetDefault("You feel a little bit tougher. \nDefense increased by 3.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statDefense += 3;
                }
            }

            public class MetalSkin2 : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Metal Skin II");
                    Description.SetDefault("You can take harder hits than usual. \nDefense increased by 5.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statDefense += 5;
                }
            }

            public class MetalSkin3 : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Metal Skin III");
                    Description.SetDefault("You feel almost as tough as iron. \nDefense increased by 7.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statDefense += 7;
                }
            }

            public class Cryoburn : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Cryoburn");
                    Description.SetDefault("The very core of your being is frozen solid.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -25;
                }
            }

            public class CryoArmour : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Cryo Armour");
                    Description.SetDefault("The deathly cold reinforces your body and increases your vitality.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statDefense += 6;
                    player.lifeRegen = 3;
                }
            }

            public class Soulburn : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soulburn");
                    Description.SetDefault("Haunted visions cripple your mind and body.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -25;
                }
            }

            public class SoulArmour : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soul Armour");
                    Description.SetDefault("The haunted flames bolster your agility and vitality.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.moveSpeed += 0.10f;
                    player.lifeRegen = 3;
                }
            }

            public class SunderedSoul : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Sundered Soul");
                    Description.SetDefault("Your soul is torn to shreds.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -12;
                }
            }

            public class ThermalSunder : ModBuff
            {

                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Thermal Sunder");
                    Description.SetDefault("Entrophy must be screaming in horror right now.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.onFrostBurn = true;
                    npc.onFire = true;
                    npc.lifeRegen = -15;
                }
            }

            public class Apparition : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Apparition");
                    Description.SetDefault("Now's your chance to run. But who does that nowadays, anyway? /nIncreases Life Regeneration by 6. \nGrants Invisibility and Featherfall.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.lifeRegen = 6;
                    player.invis = true;
                    player.slowFall = true;
                }
            }

            public class CircadianFury : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Circadian Fury");
                    Description.SetDefault("Returning to dust.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -2;
                    npc.shadowFlame = true;
                }
            }   
            
            public class Combatant : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Combatant");
                    Description.SetDefault("Your combat prowess is increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    //Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statDefense += 12;
                    player.lifeRegen = 4;
                    player.moveSpeed += 0.35f;
                }
            }

            public class Gladiator : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Gladiator");
                    Description.SetDefault("You feel like you could take on an army.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    //Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20;
                    player.endurance += 0.20f;
                    player.kbBuff = true;
                }
            }

            public class Sorcerer : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Sorcerer");
                    Description.SetDefault("Your body crackles with magical energy.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.magicDamage = 1.30f;
                    player.manaRegenBuff = true;
                    player.manaCost *= 0.7f;
                }
            }

            public class Bloodrush : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Bloodrush");
                    Description.SetDefault("Adrenaline screams through your veins.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    //Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.allDamage = 1.20f;
                    player.meleeCrit += 15;
                    player.rangedCrit += 15;
                    player.magicCrit += 15;
                    player.enemySpawns = true;
                }
            }

            public class MasterFisherman : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Master Fisherman");
                    Description.SetDefault("No fish is safe from you.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    //Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.fishingSkill += 30;
                    player.sonarPotion = true;
                    player.cratePotion = true;
                }
            }

            public class CaveDiver : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Cave Diver");
                    Description.SetDefault("You have a keen sense of what lies below you.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.pickSpeed -= .40f;
                    player.findTreasure = true;
                    player.lavaImmune = true;
                    player.dangerSense = true;
                    player.detectCreature = true;
                }
            }

            public class Skyfairer : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Skyfairer");
                    Description.SetDefault("You float through the sky with ease.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.gravControl = true;
                    player.slowFall = true;
                }
            }

            public class AquaticExplorer : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Aquatic Explorer");
                    Description.SetDefault("You're one with the fish.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.waterWalk = true;
                    player.gills = true;
                    Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
                }
            }

            public class Globetrotter : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Globetrotter");
                    Description.SetDefault("The whole world is yours to explore.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.fishingSkill += 50;
                    player.sonarPotion = true;
                    player.cratePotion = true;
                    player.pickSpeed -= .45f;
                    player.findTreasure = true;
                    player.lavaImmune = true;
                    player.dangerSense = true;
                    player.detectCreature = true;
                    player.gravControl = true;
                    player.slowFall = true;
                    player.waterWalk = true;
                    player.gills = true;
                    player.resistCold = true;
                    Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
                }
            }

            public class Constructor : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Constructor");
                    Description.SetDefault("You can build entire skyscrapers in a blink of an eye.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.tileSpeed *= 1.35f;
                    player.wallSpeed *= 1.35f;
                    player.calmed = true;
                }
            }

            public class SoulBoostMelee : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soul Boost (Melee)");
                    Description.SetDefault("Melee damage increased by 10%. \nLife regen increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.lifeRegen += 5;
                    player.meleeDamage = 1.10f;
                }
            }

            public class SoulBoostRanged : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soul Boost (Ranged)");
                    Description.SetDefault("Ranged damage increased by 10%. \nLife regen increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.lifeRegen += 5;
                    player.rangedDamage = 1.10f;
                }
            }

            public class SoulBoostMagic : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soul Boost (Magic)");
                    Description.SetDefault("Magic damage increased by 10%. \nLife regen increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.lifeRegen += 5;
                    player.magicDamage = 1.10f;
                }
            }

            public class SoulBoostSummoning : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Soul Boost (Summon)");
                    Description.SetDefault("Summon damage increased by 7%. \n+1 minion slot. \nLife regen increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.lifeRegen += 5;
                    player.minionDamage = 1.07f;
                    player.maxMinions += 1;
                }
            }

            public class MentalDegradation : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Mental Degradation");
                    Description.SetDefault("The world is melting, and only you can see it happening.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -35;
                }
            }

            public class StellarInfection : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Stellar Infection");
                    Description.SetDefault("You should see a doctor about that.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -35;
                }
            }

            public class FalseVacuum : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("False Vacuum");
                    Description.SetDefault("Yep. Entrophy is DEFINITELY screaming now.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -35;
                }
            }

            public class SolsFury : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Sol's Fury");
                    Description.SetDefault("The heat of the sun is turning you to ash.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int buffIndex)
                {
                    npc.lifeRegen = -35;
                }
            }

            public class ScarsofAnarchy : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Scars of Anarchy");
                    Description.SetDefault("Losing blood.");
                    Main.debuff[Type] = true;
                    Main.buffNoSave[Type] = false;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = false;
                }

                public override void Update(NPC npc, ref int BuffIndex)
                {
                    npc.lifeRegen = -4;
                }
            }

            public class Bloodletting : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Bloodletting");
                    Description.SetDefault("Mana regeneration increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.manaRegenBuff = true;
                }
            }

            public class Bullseye : ModBuff
            {
                public override void SetDefaults()
                {
                    DisplayName.SetDefault("Bullseye");
                    Description.SetDefault("Ranged proficiency increased.");
                    Main.debuff[Type] = false;
                    Main.buffNoSave[Type] = true;
                    Main.buffNoTimeDisplay[Type] = false;
                    canBeCleared = true;
                }

                public override void Update(Player player, ref int buffIndex)
                {
                    player.bulletDamage = 1.20f;
                    player.archery = true;
                    player.ammoPotion = true;
                }
            }
        }
    }
}