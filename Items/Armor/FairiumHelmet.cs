using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
	public class FairiumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Helmet");
			Tooltip.SetDefault("Increases Mana by 70. \nReduces Mana usage by 17% \nGrants two extra Minion slots.");
		}

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = Item.sellPrice(0, 6, 75, 0);
            item.rare = 9;
            item.defense = 19;
        }

        public override void UpdateEquip(Player player)
        {
            player.statManaMax2 += 80;
            player.manaCost *= 0.83f;
            player.maxMinions += 2;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("FairiumBreastplate") && legs.type == mod.ItemType("FairiumGreaves");
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
            recipe.AddIngredient(ItemID.SpectreMask, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 12);
            recipe.AddIngredient(mod, "FairiumBar", 6);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}