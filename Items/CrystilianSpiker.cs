using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianSpiker : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Spiker");
			Tooltip.SetDefault("Fires a spread of crystal spikes.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 21;
			item.magic = true;
            item.mana = 6;
            item.width = 32;
            item.height = 36;
            item.useTime = 11;
			item.useAnimation = 11;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 54, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("CrystilianSpike");
            item.shootSpeed = 12f;
            item.crit = 4;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                type = mod.ProjectileType("CrystilianSpike");
            }

            int numberProjectiles = 4;

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
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
            recipe.AddIngredient(mod, "ArmadanTome", 1);
            recipe.AddIngredient(mod, "CrystilianShard", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 2);
            recipe.AddIngredient(ItemID.SoulofNight, 2);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}