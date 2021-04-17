using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SnowfallSabre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snowfall Sabre");
			Tooltip.SetDefault("Throws out a beam of ice and causes snowflakes to fall. \nHas a chance to briefly inflict Frostburn.");
		}

        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.channel = true;
            item.width = 52;
            item.height = 52;
            item.useTime = 50;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 55, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SabreSnowball");
            item.shootSpeed = 13f;
            item.crit = 4;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            //int numberProjectiles = 3;
            for (int i = 0; i < 3; i++);
            {
                Vector2 starPosition = new Vector2(Main.MouseWorld.X, position.Y - 600);
                starPosition.X += Main.rand.Next(-100, 101);
                Projectile.NewProjectile(starPosition, new Vector2(0, item.shootSpeed), mod.ProjectileType("SabreSnowflake"), damage, knockBack, player.whoAmI);
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
            }
            return true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(BuffID.Frostburn, 120);
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IceBlade, 1);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddIngredient(ItemID.Shiverthorn, 3);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Silver or Tungsten Bar", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}