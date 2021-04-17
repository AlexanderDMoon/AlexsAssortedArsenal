using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SparkWandOcean : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tidespark Wand");
			Tooltip.SetDefault("Striking an enemy briefly grants the Flipper effect.");
		}

        public override void SetDefaults()
        {
            item.damage = 19;
            item.magic = true;
            item.mana = 4;
            item.width = 38;
            item.height = 34;
            item.useTime = 23;
            item.useAnimation = 23;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 12, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SparkOcean");
            item.shootSpeed = 12f;
            item.crit = 6;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.PalmWood, 20);
            recipe.AddIngredient(ItemID.Starfish, 1);
            recipe.AddIngredient(ItemID.Coral, 1);
            recipe.AddIngredient(ItemID.Seashell, 1);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}