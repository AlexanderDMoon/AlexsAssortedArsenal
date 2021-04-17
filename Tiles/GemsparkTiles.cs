using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class GemsparkPlatformAmethyst : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformAmethyst");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AmethystGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }

    public class GemsparkPlatformTopaz : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformTopaz");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TopazGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }

    public class GemsparkPlatformSapphire : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformSapphire");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SapphireGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }

    public class GemsparkPlatformEmerald : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Emerald Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformEmerald");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmeraldGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }

    public class GemsparkPlatformRuby : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruby Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformRuby");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RubyGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }

    public class GemsparkPlatformDiamond : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformDiamond");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DiamondGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();

        }
    }

    public class GemsparkPlatformAmber : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Gemspark Platform");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.rare = 2;
            item.consumable = true;
            item.createTile = mod.TileType("GemsparkPlatformAmber");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AmberGemsparkBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 8);
            recipe.AddRecipe();
        }
    }
}