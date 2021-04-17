using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CrystilianShuriken : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystilian Shuriken");
            Tooltip.SetDefault("A sharp, gravity-ignoring throwing star.");
		}

        public override void SetDefaults()
        {
            item.damage = 30;
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 15);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("CrystilianShuriken");
            item.crit = 11;
            item.consumable = true;
            item.noUseGraphic = true;
            item.maxStack = 999;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
                if (Collision.CanHit(position, 10, 0, position + muzzleOffset, 10, 0))
                {
                    position += muzzleOffset;
                }
            }

            type = mod.ProjectileType("CrystilianShuriken");
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CrystilianShard", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}