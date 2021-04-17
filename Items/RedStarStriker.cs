using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class RedStarStriker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby Star Striker");
            Tooltip.SetDefault("Fires a bolt that has a chance to light enemies on fire.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
            item.damage = 34;
            item.magic = true;
            item.mana = 6;
            item.width = 40;
            item.height = 40;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("RedStarblast");
            item.shootSpeed = 21f;
            item.crit = 4;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RedPhasewand");
            recipe.AddIngredient(ItemID.CrystalShard, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}