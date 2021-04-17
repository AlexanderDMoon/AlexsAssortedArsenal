using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class TidebenderStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tidebender Staff");
			Tooltip.SetDefault("Fires a spread of multiple Water Bolts.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.magic = true;
            item.mana = 15;
            item.width = 56;
            item.height = 56;
            item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 3, 5, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
            item.shoot = 27;
            item.shootSpeed = 12f;
            item.crit = 11;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                type = ProjectileID.WaterBolt;
            }

            int numberProjectiles = 2;

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AquaScepter, 1);
            recipe.AddIngredient(ItemID.WaterBolt, 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Bar", 8);
            recipe.AddIngredient(ItemID.SoulofNight, 12);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}