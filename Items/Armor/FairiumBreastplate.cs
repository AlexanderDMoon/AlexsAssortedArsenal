using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
	public class FairiumBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Breastplate");
			Tooltip.SetDefault("Increases Melee and movement speed speed by 15%.");
		}

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 24;
            item.value = Item.sellPrice(0, 4, 90, 0);
            item.rare = 9;
            item.defense = 27;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 0.15f;
            player.moveSpeed += 0.15f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("FairiumHelmet") && legs.type == mod.ItemType("FairiumGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases all damage by 15%. \nIncreases all critical chance by 8%. \nIncreases max Sentries by 2.");
            player.allDamage += 0.15f;
            player.magicCrit += 8;
            player.meleeCrit += 8;
            player.rangedCrit += 8;
            player.maxTurrets += 2;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TurtleScaleMail, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 12);
            recipe.AddIngredient(mod, "FairiumBar", 10);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}