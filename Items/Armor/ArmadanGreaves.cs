using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
	public class ArmadanGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armadan Greaves");
			Tooltip.SetDefault("15% chance to not consume Ammo.");
		}

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 12;
            item.value = Item.sellPrice(0, 1, 5, 0);
            item.rare = 1;
            item.defense = 7;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() > .85f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("ArmadanHelmet") && body.type == mod.ItemType("ArmadanChestplate");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases all damage by 7%. \nIncreases all critical chance by 5%. \nIncreases max Sentries by 1.");
            player.allDamage += 0.05f;
            player.magicCrit += 5;
            player.meleeCrit += 5;
            player.rangedCrit += 5;
            player.maxTurrets += 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Greaves", 1);
            recipe.AddIngredient(ItemID.NecroGreaves, 1);
            recipe.AddIngredient(ItemID.SunplateBlock, 16);
            recipe.AddIngredient(ItemID.Feather, 2);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}