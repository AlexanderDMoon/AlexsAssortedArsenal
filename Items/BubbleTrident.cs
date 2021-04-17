using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class BubbleTrident : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bubble Trident");
			Tooltip.SetDefault("Fires a spread of bubbles.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.magic = true;
            item.mana = 8;
            item.width = 56;
            item.height = 56;
            item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item85;
			item.autoReuse = true;
            item.shoot = 410;
            item.shootSpeed = 12f;
            item.crit = 2;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }
    }
}