using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Placeable
{

    public class AetheriumBrick : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Brick");
            Tooltip.SetDefault("A near indestructible brick made of an almost otherworldly metal.");
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
            item.rare = 11;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumBrick");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 1);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();

        }
    }

    public class AetheriumBrickWeathered : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weathered Aetherium Brick");
            Tooltip.SetDefault("A near indestructible brick, aged by eons of standing tall.");
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
            item.rare = 11;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumBrickWeathered");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 1);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();

        }
    }

    public class AetheriumBrickWall : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Brick Wall");
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
            item.rare = 11;
            item.consumable = true;
            item.createWall = mod.WallType("AetheriumBrickWall");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBrick", 1);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }

    public class AetheriumBrickWallWeathered : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Weathered Aetherium Brick Wall");
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
            item.rare = 11;
            item.consumable = true;
            item.createWall = mod.WallType("AetheriumBrickWallWeathered");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBrickWeathered", 1);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }

    public class AetheriumPaneling : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Paneling");
            Tooltip.SetDefault("This metal plating is nigh unbreakable.");
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
            item.rare = 11;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumPaneling");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 1);
            recipe.AddIngredient(ItemID.StoneBlock, 50);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();

        }
    }

    public class AetheriumTable : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Table");
            Tooltip.SetDefault("A near-indestructible table made of Aetherium.");
        }

        public override void SetDefaults()
        {
            item.width = 54;
            item.height = 38;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumTable");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 8);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }

    public class AetheriumChair : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Chair");
            Tooltip.SetDefault("A near-indestructible chair made of Aetherium.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 32;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumChair");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }

    public class AetheriumPlatform : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Platform");
            Tooltip.SetDefault("A more-than-sturdy platform of metal.");
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
            item.rare = 11;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumPlatform");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 12);
            recipe.AddRecipe();

        }
    }

    public class AetheriumChest : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Chest");
            Tooltip.SetDefault("A near-indestructible chest made of Aetherium.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumChest");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }

    public class AetheriumFootlocker : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aetherium Footlocker");
            Tooltip.SetDefault("A safe place to store your belongings.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("AetheriumFootlocker");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 4);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}