using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
	public class CrystilianHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Hat");
			Tooltip.SetDefault("Increases Mana by 60. \nDecreases Mana usage by 15%. \nGrants one extra Minion slot.");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 24;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 4;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 70;
            player.manaCost *= 0.85f;
            player.maxMinions += 1;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("CrystilianChestplate") && legs.type == mod.ItemType("CrystilianGreaves");
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
            recipe.AddIngredient(mod, "ArmadanHelm", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Mythril or Orichalcum Bar", 4);
            recipe.AddIngredient(mod, "CrystilianShard", 6);
            recipe.AddIngredient(ItemID.SoulofLight, 4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}