using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class IX82BlastHammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("IX-82 Blast Hammer");
            Tooltip.SetDefault("Fires a deadly, piercing laser. \n'Initiating Mercy Protocol.'");
        }

        public override void SetDefaults()
        {
            item.damage = 175;
            item.magic = true;
            item.mana = 14;
            item.width = 42;
            item.height = 24;
            item.useTime = 14;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 7, 50, 0);
            item.rare = 10;
            item.UseSound = SoundID.Item33;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("BlastHammerBeam");
            item.crit = 16;
            item.useAmmo = AmmoID.Bullet;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                type = mod.ProjectileType("BlastHammerBeam");
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
            //Might make this a Weaponsmith item.

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AetheriumBar", 12);
            recipe.AddIngredient(ItemID.FragmentVortex, 20);
            recipe.AddIngredient(ItemID.Diamond, 6);
            recipe.AddTile(mod, "PeacekeeperForge");
            recipe.AddTile(mod, "PeacekeeperAnvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}