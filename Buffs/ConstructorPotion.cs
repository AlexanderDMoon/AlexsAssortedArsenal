using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class ConstructorPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Constructor Potion");
            Tooltip.SetDefault("Increases block placement speed by 35%. \nReduces enemy aggression.");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 46;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Constructor");
            item.buffTime = 216000;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Constructor"), 216000);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BuilderPotion, 1);
            recipe.AddIngredient(ItemID.CalmingPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}