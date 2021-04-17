using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class HEIGrenade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("H.E.I. Grenade");
            Tooltip.SetDefault("Explodes on impact with an enemy. \nHas a chance to inflict a bleed debuff for a short time.");
		}

        public override void SetDefaults()
        {
            item.damage = 80;
            item.ranged = true;
            item.width = 16;
            item.height = 20;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 8;
            item.value = Item.sellPrice(0, 0, 0, 30);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 6f;
            item.shoot = mod.ProjectileType("HEIGrenade");
            item.crit = 6;
            item.consumable = true;
            item.noUseGraphic = true;
            item.maxStack = 99;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = mod.ProjectileType("HEIGrenade");
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GunpowderCore", 1);
            recipe.AddIngredient(ItemID.ExplosivePowder, 3);
            recipe.AddIngredient(ItemID.Grenade, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}