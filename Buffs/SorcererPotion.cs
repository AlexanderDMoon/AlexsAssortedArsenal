using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class SorcererPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sorcerer Potion");
            Tooltip.SetDefault("30% increased Magic damage. \n30% increased Mana Efficiency. \nIncreases Mana regeneration.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 44;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Sorcerer");
            item.buffTime = 25200;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Sorcerer"), 25200);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicPowerPotion, 1);
            recipe.AddIngredient(ItemID.ManaRegenerationPotion, 1);
            recipe.AddIngredient(mod, "ManaChargerPotion", 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}