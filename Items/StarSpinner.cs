using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class StarSpinner : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Spinner");
            Tooltip.SetDefault("Fires one of four homing Lunar projectiles, each inflicting a different Debuff. \n'It's for the best that the world knows you're still alive.'");
            Terraria.Item.staff[item.type] = true;
		}


		public override void SetDefaults()
		{
			item.damage = 210;
			item.magic = true;
            item.mana = 14;
			item.width = 50;
			item.height = 50;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
            item.noMelee = true;
			item.knockBack = 10;
            item.value = Item.sellPrice(0, 11, 50, 0);
            item.rare = 11;
			item.UseSound = SoundID.Item9;
			item.autoReuse = true;
            item.shoot = mod.ProjectileType("StarSpinnerNebula"); //ignore this lmao
            item.shootSpeed = 21f;
            item.crit = 11;
        }

        private int[] _starSpinner = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerNebula"),
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerSolar"),
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerStardust"),
            AlexsAssortedArsenal.Instance.ProjectileType("StarSpinnerVortex")
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {                       
            type = Main.rand.Next(_starSpinner);

            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
            if (Collision.CanHit(position, 10, 0, position + muzzleOffset, 10, 0))
            {
                position += muzzleOffset;
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "FallenHallow");
            recipe.AddIngredient(ItemID.FragmentSolar, 15);
            recipe.AddIngredient(ItemID.FragmentVortex, 15);
            recipe.AddIngredient(ItemID.FragmentStardust, 15);
            recipe.AddIngredient(ItemID.FragmentNebula, 15);
            recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}