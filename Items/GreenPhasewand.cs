using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class GreenPhasewand : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Emerald Phasewand");
            Tooltip.SetDefault("");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
            item.damage = 20;
            item.magic = true;
            item.mana = 8;
            item.width = 36;
            item.height = 36;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 54, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("GreenPhaseblast");
            item.shootSpeed = 12f;
            item.crit = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 13);
            recipe.AddIngredient(ItemID.Emerald, 8);
            recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}