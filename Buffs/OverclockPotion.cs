using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class OverclockPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Overclock Potion");
            Tooltip.SetDefault("Doubles ALL damage and crit chance. \nDoubles melee speed. \nInflicts Potion Sickness for 30 seconds. \nIncreases your Defense by 20. \nIncreases movement speed by 15%. \nIncreases Mana Regeneration. \nIncreases the velocity of thrown weapons. \nCannot be used while inflicted with Potion Sickness. \n'If there's one thing I've learned, it's that you should never go at it alone.'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 56;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 8, 75, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item3;
            item.maxStack = 10;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Overclocked");
            item.buffTime = 720;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Overclocked"), 720);
            player.AddBuff(BuffID.PotionSickness, 1800);

            return true;
        }
        public override bool CanUseItem(Player player)
        {
            return !player.HasBuff(BuffID.PotionSickness);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CombatPotion", 1);
            recipe.AddIngredient(mod, "GladiatorPotion", 1);
            recipe.AddIngredient(mod, "SorcererPotion", 1);
            recipe.AddIngredient(mod, "BloodrushPotion", 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}