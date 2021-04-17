using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class RaindropRapier : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Raindrop Rapier");
			Tooltip.SetDefault("Deals 50% more damage while in the rain, or while submerged in water.");
            //Terraria.Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 11;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 3;
            item.useTurn = false;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 35, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 2;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(BuffID.Wet, 180);
            }
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

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalmWoodSword, 1);
            recipe.AddIngredient(ItemID.Waterleaf, 5);
            recipe.AddIngredient(ItemID.WaterBucket, 3);
            recipe.AddIngredient(ItemID.FallenStar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}