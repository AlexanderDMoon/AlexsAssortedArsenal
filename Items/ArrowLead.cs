using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class ArrowLead : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lead Arrow");
            Tooltip.SetDefault("Striking an enemy grants you a minor defensive buff.");
		}

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 14;
            item.height = 40;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 2);
            item.rare = 0;
            item.shoot = mod.ProjectileType("ArrowLead");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 1);
            recipe.AddIngredient(ItemID.Wood, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}