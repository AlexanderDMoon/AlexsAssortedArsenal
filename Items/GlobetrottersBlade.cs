using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class GlobetrottersBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Globetrotter's Blade");
			Tooltip.SetDefault("Throws puffs of clouds and snowflakes. \nDirect strikes 50% more damage while in the rain, or while submerged in water. \nDirect strikes have chance to briefly inflict heavy bleeding.");
		}

        public override void SetDefaults()
        {
            item.damage = 26;
            item.melee = true;
            item.width = 56;
            item.height = 62;
            item.useTime = 50;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SabreSnowball");
            item.shootSpeed = 12f;
            item.crit = 2;
        }

        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (player.wet)
            {
                damage = (int)(damage * 1.5f);
            }

            else if (Main.raining)
            {
                damage = (int)(damage * 1.5f);
            }
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(4) == 0)
            {
                target.AddBuff(mod.BuffType("Slashed"), 60);
                target.AddBuff(BuffID.Frostburn, 60);
            }
        }

        private int[] _globetrottersBlade = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("SabreSnowball"),
            AlexsAssortedArsenal.Instance.ProjectileType("CloudBolt"),
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            int numberProjectiles = 2;

            for (int i = 0; i < numberProjectiles; i++)
            {
                type = Main.rand.Next(_globetrottersBlade);
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
                float scale = 1f - (Main.rand.NextFloat() * .3f);
                perturbedSpeed = perturbedSpeed * scale;
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "RaindropRapier", 1);
            recipe.AddIngredient(mod, "CloudborneKhopesh", 1);
            recipe.AddIngredient(mod, "SnowfallSabre", 1);
            recipe.AddIngredient(mod, "SandstormSerrator", 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ItemID.CrystalShard, 3);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this);
            recipe.AddRecipe();
            
        }
	}
}