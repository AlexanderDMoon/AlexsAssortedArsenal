using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class CaveDiversPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cave Diver's Potion");
            Tooltip.SetDefault("Grants the Spelunker, Hunter and Dangersense potion effects. \nIncreases Mining speed by 40%. \nGrants immunity to Lava.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 44;
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
            item.buffType = mod.BuffType("CaveDiver");
            item.buffTime = 43200;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("CaveDiver"), 43200);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MiningPotion, 1);
            recipe.AddIngredient(ItemID.SpelunkerPotion, 1);
            recipe.AddIngredient(ItemID.ObsidianSkinPotion, 1);
            recipe.AddIngredient(ItemID.HunterPotion, 1);
            recipe.AddIngredient(ItemID.TrapsightPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}