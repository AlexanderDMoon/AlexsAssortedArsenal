using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FairiumBolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fairium Bolt");
            Tooltip.SetDefault("An arrow forged from enchanted steel. \nStriking an enemy breifly grants you a minor Defense and Life Regen increase.");
		}

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 18;
            item.height = 40;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 30);
            item.rare = 6;
            item.shoot = mod.ProjectileType("FairiumBolt");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "FairiumBar", 1);
            recipe.AddIngredient(ItemID.SoulofLight, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 125);
			recipe.AddRecipe();
		}
	}
}