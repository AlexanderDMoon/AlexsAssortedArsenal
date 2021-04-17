using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
	public class CrystilianChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Chestplate");
			Tooltip.SetDefault("Increases Melee speed and movement speed by 10%.");
		}

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 20;
            item.value = Item.sellPrice(0, 1, 20, 0);
            item.rare = 4;
            item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.1f;
            player.moveSpeed += 0.1f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("CrystilianHat") && legs.type == mod.ItemType("CrystilianGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases all damage by 12%. \nIncreases all critical chance by 7%. \nIncreases max Sentries and Minions by 1.");
            player.allDamage += 0.12f;
            player.magicCrit += 7;
            player.meleeCrit += 7;
            player.rangedCrit += 7;
            player.maxTurrets += 1;
            player.maxMinions += 1;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ArmadanChestplate", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Mythril or Orichalcum Bar", 8);
            recipe.AddIngredient(mod, "CrystilianShard", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}