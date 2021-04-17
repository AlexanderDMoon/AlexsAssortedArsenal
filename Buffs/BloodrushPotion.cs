using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class BloodrushPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bloodrush Potion");
            Tooltip.SetDefault("20% increased damage. \n15% increased crit chance. \nIncreases enemy spawnrates.");
        }

        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 36;
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
            item.buffType = mod.BuffType("Bloodrush");
            item.buffTime = 25200;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Bloodrush"), 25200);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WrathPotion, 1);
            recipe.AddIngredient(ItemID.RagePotion, 1);
            recipe.AddIngredient(ItemID.BattlePotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}