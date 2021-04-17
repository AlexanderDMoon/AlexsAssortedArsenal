using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
	public class ArmadanChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armadan Chestplate");
			Tooltip.SetDefault("Increases Melee speed by 5%. \nIncreases movement speed by 8%.");
		}

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 15, 0);
            item.rare = 1;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.05f;
            player.moveSpeed += 0.08f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("ArmadanHelmet") && legs.type == mod.ItemType("ArmadanGreaves");
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
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Chestpiece", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Shadowscale or Crimson Chestpiece", 1);
            recipe.AddIngredient(ItemID.SunplateBlock, 20);
            recipe.AddIngredient(ItemID.Feather, 3);
            recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}