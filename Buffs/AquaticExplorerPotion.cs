using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class AquaticExplorerPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquatic Explorer Potion");
            Tooltip.SetDefault("Grants the Gills, Waterwalking and Shine potion effects.");
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
            item.value = Item.sellPrice(0, 0, 3, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("AquaticExplorer");
            item.buffTime = 28800;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("AquaticExplorer"), 28800);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GillsPotion, 1);
            recipe.AddIngredient(ItemID.WaterWalkingPotion, 1);
            recipe.AddIngredient(ItemID.ShinePotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}