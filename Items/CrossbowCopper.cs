using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CrossbowCopper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Copper Crossbow");
            Tooltip.SetDefault("Fires Copper Arrows when using Wooden Arrows as ammo. \nRight-click to zoom out.");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 56;
            item.height = 28;
            item.useTime = 24;
            item.useAnimation = 24;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 90, 0);
            item.rare = 0;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("ArrowCopper");
            item.crit = 2;
            item.useAmmo = AmmoID.Arrow;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = mod.ProjectileType("ArrowCopper");
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, -3);
        }

        public override void HoldItem(Player player)
        {
            player.scope = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBow, 1);
            recipe.AddIngredient(ItemID.WhiteString, 1);
            recipe.AddIngredient(ItemID.CopperBar, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}