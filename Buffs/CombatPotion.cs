using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class CombatPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Combat Potion");
            Tooltip.SetDefault("Increases Defense by 12. \n35% increased movement speed. \nIncreases health regeneration.");
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
            item.buffType = mod.BuffType("Combatant");
            item.buffTime = 28800;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Combatant"), 28800);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronskinPotion, 1);
            recipe.AddIngredient(ItemID.RegenerationPotion, 1);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}