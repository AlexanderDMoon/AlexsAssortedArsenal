using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class PeacekeeperCoilgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Coilgun");
            Tooltip.SetDefault("Uses various Coilgun Bolts as ammo. \n'A coilgun of ancient construction, designed to laugh in the face of anyone within a thousand miles.'");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.ranged = true;
            item.width = 84;
            item.height = 34;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("CoilgunBolt");
            item.crit = 12;
            item.useAmmo = mod.ProjectileType("CoilgunBolt");
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == mod.ProjectileType("CoilgunBolt"))
            {
                type = mod.ProjectileType("CoilgunBolt");
            }

            if (type == mod.ProjectileType("CoilgunFletchetteBolt"))
            {
                type = mod.ProjectileType("CoilgunFletchetteBolt");
            }

            if (type == mod.ProjectileType("CoilgunIncendiaryBolt"))
            {
                type = mod.ProjectileType("CoilgunIncendiaryBolt");
            }

            if (type == mod.ProjectileType("CoilgunExplosiveBolt"))
            {
                type = mod.ProjectileType("CoilgunExplosiveBolt");
            }

            if (type == mod.ProjectileType("CoilgunBoltEnergized"))
            {
                type = mod.ProjectileType("CoilgunBoltEnergized");
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, -1);
        }

        public override void AddRecipes()
        {
            //Weaponsmith will require-
            //- 1 Adamantite/Titanium Musket
            //- 1 Ancient Coil Mechanism (Dropped from Skeletron Prime)
            //- 12 Souls of Might.

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AdamantiteMusket", 1);
            recipe.AddIngredient(ItemID.SoulofMight, 12);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TitaniumMusket", 1);
            recipe.AddIngredient(ItemID.SoulofMight, 12);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}