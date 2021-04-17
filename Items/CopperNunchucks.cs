using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CopperNunchucks : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Nunchucks");
            Tooltip.SetDefault("Has a chance to confuse struck enemies.");
        }
		public override void SetDefaults()
		{
			item.damage = 6;
            item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 24;
			item.useAnimation = 24;
            item.channel = true;
			item.useStyle = 5;
			item.knockBack = 4;
            item.value = Item.sellPrice(0, 0, 0, 75);
            item.rare = 0;
			item.UseSound = SoundID.Item1;
            item.crit = 20;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("NunchuckSlash");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 6);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}