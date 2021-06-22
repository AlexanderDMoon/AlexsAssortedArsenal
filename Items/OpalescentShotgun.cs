using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class OpalescentShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Opalescent Shotgun");
            Tooltip.SetDefault("Fires a powerful spread of Gemspark bullets. \n'Like a god, slamming a car door.'");
        }

        public override void SetDefaults()
        {
            item.damage = 67;
            item.ranged = true;
            item.width = 76;
            item.height = 28;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item38;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("DiamondBullet");
            item.crit = 11;
            item.useAmmo = AmmoID.Bullet;
        }

        private int[] _opalescentShotgun = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("AmethystBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("TopazBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("SapphireBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("EmeraldBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("RubyBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("DiamondBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("AmberBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("AquamarineBullet"),
            AlexsAssortedArsenal.Instance.ProjectileType("PenumbriteBullet")
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6;

            for (int i = 0; i < numberProjectiles; i++)
            {
                type = Main.rand.Next(_opalescentShotgun);
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
                return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44AC", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44TT", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44AI", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44PL", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44SS", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44ET", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44RG", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "GeMP44DP", 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}