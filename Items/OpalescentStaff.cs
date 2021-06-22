using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class OpalescentStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Opalescent Staff");
            Tooltip.SetDefault("Fires a powerful spread of Gemstone projectiles.");
            Terraria.Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.magic = true;
            item.mana = 13;
            item.width = 52;
            item.height = 58;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("WhiteStarblast");
            item.crit = 11;
        }

        private int[] _opalescentStaff = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("PurpleStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("YellowStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("BlueStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("GreenStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("RedStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("WhiteStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("AmberStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("AquamarineStarblast"),
            AlexsAssortedArsenal.Instance.ProjectileType("PenumbriteStarblast")
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            int numberProjectiles = 6;

            for (int i = 0; i < numberProjectiles; i++)
            {
                type = Main.rand.Next(_opalescentStaff);
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
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
            recipe.AddIngredient(ItemID.AmethystStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TopazStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "IronStaff", 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LeadStaff", 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SapphireStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EmeraldStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RubyStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DiamondStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
            recipe.AddIngredient(ItemID.SoulofSight, 15);
            recipe.AddIngredient(mod, "FairiumBar", 12);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 150);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AmberStaff, 1);
            recipe.AddIngredient(ItemID.RainbowRod, 1);
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