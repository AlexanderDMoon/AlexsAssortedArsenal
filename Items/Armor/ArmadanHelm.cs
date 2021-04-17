using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
	public class ArmadanHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armadan Helm");
			Tooltip.SetDefault("Increases Mana by 30. \nDecreases Mana usage by 12%. \nGrants one extra Minion slot.");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 30;
            player.manaCost *= 0.88f;
            player.maxMinions += 1;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ArmadanChestplate") && legs.type == mod.ItemType("ArmadanGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases all damage by 7%. \nIncreases all critical chance by 5%. \nIncreases max Sentries by 1.");
            player.allDamage += 0.07f;
            player.magicCrit += 5;
            player.meleeCrit += 5;
            player.rangedCrit += 5;
            player.maxTurrets += 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Helmet", 1);
            recipe.AddIngredient(ItemID.JungleHat, 1);
            recipe.AddIngredient(ItemID.SunplateBlock, 15);
            recipe.AddIngredient(ItemID.Feather, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}