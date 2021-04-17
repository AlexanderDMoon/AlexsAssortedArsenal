using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class M1Gangarand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("M1 Gangarand");
            Tooltip.SetDefault("Fires high-velocity Blightburn Bullets when using Musket Shot as ammo. \nBlightburn Bullets have a chance to inflict Frostburn and Cursed Inferno.");
        }

        public override void SetDefaults()
        {
            item.damage = 115;
            item.ranged = true;
            item.width = 100;
            item.height = 24;
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
            item.shoot = mod.ProjectileType("BlightburnHighVelocity");
            item.crit = 12;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("BlightburnHighVelocity");
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
            recipe.AddIngredient(mod,"PutridPerforator", 1);
            recipe.AddIngredient(ItemID.SniperRifle, 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddIngredient(mod, "SoulofChills", 8);
            recipe.AddIngredient(ItemID.Ectoplasm, 12);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}