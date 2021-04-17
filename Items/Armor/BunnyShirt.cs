using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
	public class BunnyShirt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Shirt");
			Tooltip.SetDefault("Increases Minion damage by 4%.");
		}

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 20;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.rare = 1;
            item.defense = 2;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.04f;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return head.type == ItemID.BunnyHood && legs.type == mod.ItemType("BunnyPants");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = ("Increases Minion damage by a further 3%. \nGrants one minion slot. \nGrants immunity to Chilled. \n'It's not a phase, mom!'");

            player.minionDamage += 0.03f;
            player.maxMinions += 1;
            player.buffImmune[BuffID.Electrified] = true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BunnyPelt", 12);
            recipe.AddIngredient(ItemID.Silk, 6);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}