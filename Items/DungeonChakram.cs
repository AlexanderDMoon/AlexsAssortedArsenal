using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class DungeonChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tideglaive");
            Tooltip.SetDefault("");
		}

        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("DungeonChakram");
            item.crit = 11;
            item.consumable = false;
            item.noUseGraphic = true;
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

            type = mod.ProjectileType("DungeonChakram");
            return true;
        }
	}
}