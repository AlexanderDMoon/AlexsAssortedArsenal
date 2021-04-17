using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CharmOfNami : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Charm of Nami");
            Tooltip.SetDefault("Increases melee and minion damage by 16%. \nDirect Melee strikes and Minion damage inflicts On Fire! for 10 seconds. \n'Once held by an ancient Pyromancer, this coin embues the holder with flaming power.");
		}

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 7, 25, 0);
            item.rare = 8;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.16f;
            player.minionDamage += 0.16f;
            player.GetModPlayer<AAAModPlayer>().CharmOfNamiEffect = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PeacekeeperEmblem", 1);
            recipe.AddIngredient(mod, "SoulofThrills", 8);
            recipe.AddIngredient(ItemID.LightShard, 2);
            recipe.AddIngredient(ItemID.SunStone, 1);
            recipe.AddTile(mod, "PeacekeeperAnvil");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}