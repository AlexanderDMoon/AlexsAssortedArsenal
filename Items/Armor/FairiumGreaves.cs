using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
	public class FairiumGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Greaves");
			Tooltip.SetDefault("18% chance to not consume Ammo.");
		}

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 16;
            item.value = Item.sellPrice(0, 4, 65, 0);
            item.rare = 9;
            item.defense = 15;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() > .82f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == mod.ItemType("FairiumHelmet") && legs.type == mod.ItemType("FairiumBreastplate");
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
            recipe.AddIngredient(ItemID.ShroomiteLeggings, 1);
            recipe.AddIngredient(ItemID.SoulofMight, 12);
            recipe.AddIngredient(mod, "FairiumBar", 8);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}