using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class MirrorbackPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mirrorback Potion");
            Tooltip.SetDefault("Contact damage you take is amplified and dealt back to your attacker. \n'The silvery liquid within the flask almost looks like glass. You wonder if drinking this is even safe.'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 40;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 1, 15, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Mirrorback");
            item.buffTime = 9000;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Mirrorback"), 9000);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Glass, 6);
            recipe.AddIngredient(ItemID.ThornsPotion, 2);
            recipe.AddIngredient(ItemID.PixieDust, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}