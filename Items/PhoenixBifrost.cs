using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class PhoenixBifrost : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phoenix Bifrost");
			Tooltip.SetDefault("Inflicts Cryoburn on an enemy for five seconds.");
		}

        public override void SetDefaults()
        {
            item.damage = 72;
            item.melee = true;
            item.channel = true;
            item.width = 60;
            item.height = 62;
            item.useTime = 7;
            item.useAnimation = 7;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 6;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 6;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("Cryoburn"), 300);
            target.AddBuff(BuffID.Frostburn, 300);
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Frostbrand, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 8);
            recipe.AddIngredient(mod, "SoulofChills", 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}