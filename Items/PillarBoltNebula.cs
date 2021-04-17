using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class PillarBoltNebula : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solarbane Javelin");
            Tooltip.SetDefault("An ethereal javelin that deals double damage towards the Solar Pillar and it's enemies. \nRicochets up to four times upon striking an enemy.");
		}

        public override void SetDefaults()
        {
            item.damage = 55;
            item.magic = true;
            item.width = 46;
            item.height = 46;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 3);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shootSpeed = 10f;
            item.shoot = mod.ProjectileType("PillarBoltNebula");
            item.crit = 6;
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

            type = mod.ProjectileType("PillarBoltNebula");
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentNebula, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this, 33);
			recipe.AddRecipe();
		}
	}
}