using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MoltenScepter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Sceptre");
            Tooltip.SetDefault("Fires a bouncing beam of fire.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 33;
			item.magic = true;
            item.mana = 8;
            item.width = 40;
            item.height = 40;
            item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 10;
            item.value = Item.sellPrice(0, 0, 45, 0);
            item.rare = 3;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("MoltenBeam");
            item.shootSpeed = 21f;
            item.crit = 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}