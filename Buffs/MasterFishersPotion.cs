using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class MasterFishersPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Master Fisherman's Potion");
            Tooltip.SetDefault("Increases Fishing Power by 30. \nGrants Crate and Sonar potion effects.");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 40;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 5, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("MasterFisherman");
            item.buffTime = 50400;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("MasterFisherman"), 50400);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FishingPotion, 1);
            recipe.AddIngredient(ItemID.CratePotion, 1);
            recipe.AddIngredient(ItemID.SonarPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}