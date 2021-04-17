using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class GlobetrotterPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Globetrotter Potion");
            Tooltip.SetDefault("Increases Fishing power by 50. \nIncreases Mining speed by 45%. \nGrants potion effects from the Sonar, Crate, Spelunker, Obsidian Skin, Dangersense, \nHunter, Gravitation, Featherfall, Gills, Shine and Warmth Potions.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 42;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 30, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Globetrotter");
            item.buffTime = 324000;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Globetrotter"), 324000);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AquaticExplorerPotion", 1);
            recipe.AddIngredient(mod, "CaveDiversPotion", 1);
            recipe.AddIngredient(mod, "MasterFishersPotion", 1);
            recipe.AddIngredient(mod, "SkyfairerPotion", 1);
            recipe.AddIngredient(ItemID.WarmthPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}