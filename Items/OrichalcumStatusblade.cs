using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class OrichalcumStatusblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Statusblade");
			Tooltip.SetDefault("Striking an enemy grants you Heartreach for several seconds.");
		}

        public override void SetDefaults()
        {
            item.damage = 57;
            item.melee = true;
            item.channel = true;
            item.width = 72;
            item.height = 76;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.useTurn = false;
            item.knockBack = 6;
            item.value = Item.sellPrice(0, 1, 80, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 10;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(BuffID.Heartreach, 180);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OrichalcumSword, 1);
            recipe.AddIngredient(ItemID.PearlstoneBlock, 20);
            recipe.AddIngredient(ItemID.PixieDust, 8);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}