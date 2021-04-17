using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class FNFLAY : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("FN-FLAY");
            Tooltip.SetDefault("Fires high-velocity Bloodburn Bullets when using Musket Shot as ammo. \nBloodburn Bullets have a chance to inflict Frostburn and Ichor.");
        }

        public override void SetDefaults()
        {
            item.damage = 98;
            item.ranged = true;
            item.width = 94;
            item.height = 28;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 9, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("BloodburnHighVelocity");
            item.crit = 12;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("BloodburnHighVelocity");
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-22, -3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,"SanguineSnowballer", 1);
            recipe.AddIngredient(ItemID.SniperRifle, 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddIngredient(mod, "SoulofThrills", 8);
            recipe.AddIngredient(ItemID.Ectoplasm, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}