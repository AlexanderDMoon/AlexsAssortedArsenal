using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Scatterscorch : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scatterscorch");
            Tooltip.SetDefault("Uses Gel for ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.ranged = true;
            item.width = 56;
            item.height = 16;
            item.useTime = 37;
            item.useAnimation = 37;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item38;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("ScatterscorchProj");
            item.crit = 6;
            item.useAmmo = AmmoID.Gel;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            int numberProjectiles = 4;

            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
                return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-7, 0);
        }
    }
}