using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class SoulRegenSummoning : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Potion of Spite");
            Tooltip.SetDefault("7% increased Minion damage. \n+1 minion slot. \nGreatly increases life regen.");
        }

        public override void SetDefaults()
        {
            item.width = 12;
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
            item.buffType = mod.BuffType("SoulBoostSummoning");
            item.buffTime = 10800;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("SoulBoostSummoning"), 10800);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RobustPotionFlask", 1);
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}