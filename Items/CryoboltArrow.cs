using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CryoboltArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cryobolt Arrow");
            Tooltip.SetDefault("Has a chance to inflict a devastating damage over time debuff. \nStriking an enemy grants you a defense and regen-boosting buff.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 14;
            item.height = 32;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 6);
            item.rare = 6;
            item.shoot = mod.ProjectileType("Cryobolt");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.UnholyArrow, 75);
            recipe.AddIngredient(mod, "SoulofChills", 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 75);
			recipe.AddRecipe();
		}
	}
}