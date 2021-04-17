using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Hellraiser : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellraiser Revolver");
            Tooltip.SetDefault("\nFires an extremely powerful, explosive bullet when using Musket Shot as ammo. \n'Even the ancients had rivals.'");
		}

        public override void SetDefaults()
        {
            item.damage = 140;
            item.ranged = true;
            item.width = 52;
            item.height = 36;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 8, 60, 0);
            item.rare = 8;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 40f;
            item.shoot = ProjectileID.ExplosiveBullet;
            item.crit = 25;
            item.useAmmo = AmmoID.Bullet;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = ProjectileID.ExplosiveBullet;
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1, -3);
        }

        public override void AddRecipes()
        {
            //Weaponsmith Item

            //- 1 "Ballistic Converter" (Identified by Analyzer)
            //- 1 Peacekeeper Revolver
            //- 5 Luminite Bars
            //- 12 Solar Fragments

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PeacekeeperRevolver", 1);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.FragmentVortex, 12);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}
 