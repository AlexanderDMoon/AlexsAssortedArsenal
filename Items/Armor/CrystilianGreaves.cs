using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
	public class CrystilianGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Greaves");
			Tooltip.SetDefault("15% chance to not consume Ammo.");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 12;
            item.value = Item.sellPrice(0, 1, 10, 0);
            item.rare = 4;
            item.defense = 10;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() > .85f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("CrystilianHat") && legs.type == mod.ItemType("CrystilianBreastplate");
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
            recipe.AddIngredient(mod, "ArmadanGreaves", 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Mythril or Orichalcum Bar", 6);
            recipe.AddIngredient(mod, "CrystilianShard", 8);
            recipe.AddIngredient(ItemID.SoulofNight, 4);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}