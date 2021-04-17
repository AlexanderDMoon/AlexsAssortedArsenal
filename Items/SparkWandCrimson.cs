using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SparkWandCrimson : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloodspark Wand");
			Tooltip.SetDefault("Striking an enemy briefly grants the Regeneration effect.");
		}

        public override void SetDefaults()
        {
            item.damage = 17;
            item.magic = true;
            item.mana = 4;
            item.width = 38;
            item.height = 34;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 12, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SparkCrimson");
            item.shootSpeed = 12f;
            item.crit = 6;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WandofSparking, 1);
            recipe.AddIngredient(ItemID.Shadewood, 20);
            recipe.AddIngredient(ItemID.Deathweed, 3);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}