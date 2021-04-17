using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SparkWandHallow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Faespark Wand");
			Tooltip.SetDefault("Striking an enemy briefly grants the Enchanted effect.");
		}

        public override void SetDefaults()
        {
            item.damage = 23;
            item.magic = true;
            item.mana = 3;
            item.width = 38;
            item.height = 34;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 12, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SparkHallow");
            item.shootSpeed = 12f;
            item.crit = 8;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.Pearlwood, 20);
            recipe.AddIngredient(ItemID.Daybloom, 3);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}