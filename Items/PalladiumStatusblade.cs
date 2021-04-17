using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class PalladiumStatusblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palladium Statusblade");
			Tooltip.SetDefault("Striking an enemy grants you several seconds of rapid life regen.");
		}

        public override void SetDefaults()
        {
            item.damage = 49;
            item.melee = true;
            item.channel = true;
            item.width = 70;
            item.height = 70;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 1, 10, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 8;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(BuffID.RapidHealing, 300);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PalladiumSword, 1);
            recipe.AddIngredient(ItemID.CrystalShard, 12);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}