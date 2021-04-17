using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class GaiasBramble : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gaia's Bramble");
            Tooltip.SetDefault("Fires a powerful spread of sparks that burst into fragments. \nLegendary Weapon");
            Terraria.Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 53;
            item.magic = true;
            item.mana = 14;
            item.width = 52;
            item.height = 58;
            item.useTime = 22;
            item.useAnimation = 22;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(2, 0, 0, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item9;
            item.autoReuse = true;
            item.shootSpeed = 18f;
            item.shoot = mod.ProjectileType("BrambleSparkCorruption");
            item.crit = 13;
            item.expert = true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        private int[] _Everglade = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkCorruption"),
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkCrimson"),
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkHallow"),
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkJungle"),
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkOcean"),
            AlexsAssortedArsenal.Instance.ProjectileType("BrambleSparkSnow"),
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3;

            for (int i = 0; i < numberProjectiles; i++)
            {
                type = Main.rand.Next(_Everglade);
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
            recipe.AddIngredient(mod, "Everglade", 1);
            recipe.AddIngredient(mod, "SoulboundDew", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}