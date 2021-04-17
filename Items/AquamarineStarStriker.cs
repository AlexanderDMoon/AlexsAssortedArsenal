using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AquamarineStarStriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine Star Striker");
            Tooltip.SetDefault("Fires a bolt that deals more damage to Fire-based enemies.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.magic = true;
            item.mana = 6;
            item.width = 40;
            item.height = 40;
            item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 10;
            item.value = Item.sellPrice(0, 0, 45, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("AquamarineStarblast");
            item.shootSpeed = 21f;
            item.crit = 4;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AquamarinePhasewand");
            recipe.AddIngredient(ItemID.CrystalShard, 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}