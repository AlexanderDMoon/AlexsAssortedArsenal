using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class BoomEcho : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boom Echo");
            Tooltip.SetDefault("Fires a wave of wind energy.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.magic = true;
            item.mana = 10;
            item.width = 54;
            item.height = 54;
            item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 10;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 1;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("EchoWave");
            item.shootSpeed = 21f;
            item.crit = 0;
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {           
            type = mod.ProjectileType("EchoWave");           
            return true;
        }
	}
}