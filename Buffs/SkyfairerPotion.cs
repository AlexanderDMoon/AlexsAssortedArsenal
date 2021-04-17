using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class SkyfairerPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Skyfairer Potion");
            Tooltip.SetDefault("Grants Featherfall and Gravitation effects.");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 38;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Skyfairer");
            item.buffTime = 28800;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Skyfairer"), 28800);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GravitationPotion, 1);
            recipe.AddIngredient(ItemID.FeatherfallPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}