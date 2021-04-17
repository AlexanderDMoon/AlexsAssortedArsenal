using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CrystilianCarbine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystilian Carbine");
            Tooltip.SetDefault("Fires a burst of three life-leeching Sapper rounds when using Musket Shot as ammo. \nHas a moderately high crit chance. \nThere is a somewhat long delay between bursts.");
        }

        public override void SetDefaults()
        {
            item.damage = 21;
            item.ranged = true;
            item.width = 64;
            item.height = 26;
            item.useTime = 4;
            item.useAnimation = 12;
            item.reuseDelay = 35;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 3, 50, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item31;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("CrystilianCarbineShot");
            item.crit = 16;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("CrystilianCarbineShot");
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-6, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ClockworkAssaultRifle, 1);
            recipe.AddIngredient(mod, "CrystilianShard", 12);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}