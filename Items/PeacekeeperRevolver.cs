using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class PeacekeeperRevolver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Revolver");
            Tooltip.SetDefault("This weapon fires a piercing High-Velocity Bullet when using Musket Shot as ammo. \n'A weapon once wielded by an ancient gunslinger; The name etched on the barrel indicates its previous owner was named Rubico.'");
        }

        public override void SetDefaults()
        {
            item.damage = 75;
            item.ranged = true;
            item.width = 46;
            item.height = 26;
            item.useTime = 9;
            item.useAnimation = 9;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 5, 75, 0);
            item.rare = 7;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("ArmourPiercingBullet");
            item.crit = 17;
            item.useAmmo = AmmoID.Bullet;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("ArmourPiercingBullet");
            }

            Vector2 muzzleOffset = Vector2.Normalize(new Vector2(0, 0));
            if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
            {
                position += muzzleOffset;
            }

            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1, -2);
        }

        public override void AddRecipes()
        {
            //Weaponsmith Item

            //- 1 Ancient Revolver (Identified by Analayzer
            //- 1 Ancient Coin (Gained from a Slayer Contract; Identified by Analayzer
            //- 8 Shroomite Bars

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VenusMagnum, 1);
            recipe.AddIngredient(mod,"PeacekeeperCharm", 1);
            recipe.AddIngredient(ItemID.ShroomiteBar, 8);
            recipe.AddTile(mod, "PeacekeeperForge");
            recipe.AddTile(mod, "PeacekeeperAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}