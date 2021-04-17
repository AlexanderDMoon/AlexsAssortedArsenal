using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Buffs
{
    public class BullseyePotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bullseye Potion");
            Tooltip.SetDefault("Increases Ranged damage by 20%. \nArrow speed increased by 20%. \n20% chance to not consume ammo.");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 34;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 3, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.autoReuse = false;
            item.buffType = mod.BuffType("Bullseye");
            item.buffTime = 36000;
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("Bullseye"), 36000);
            return true;
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ArcheryPotion, 1);
            recipe.AddIngredient(ItemID.AmmoReservationPotion, 1);
            recipe.AddTile(TileID.AlchemyTable);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}