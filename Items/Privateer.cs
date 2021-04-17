using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Privateer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Privateer");
            Tooltip.SetDefault("Fires bullets that aren't slowed by water when using Musket Shot as ammo.");
		}

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 32;
            item.height = 20;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 20, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 14f;
            item.shoot = ProjectileID.Bullet;
            item.crit = 1;
            item.useAmmo = AmmoID.Bullet;

        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 1);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("PrivateerShot");
            }
            return true;
        }
	}
}