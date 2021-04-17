using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class IronStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Staff");
			Tooltip.SetDefault("Fires a bolt of magic that deals more damage to fire-based enemies.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
            item.damage = 16;
            item.magic = true;
            item.mana = 4;
            item.width = 40;
            item.height = 40;
            item.useTime = 36;
            item.useAnimation = 36;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 6, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("AquamarineBolt");
            item.shootSpeed = 12f;
            item.crit = 2;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(mod, "Aquamarine", 8);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}