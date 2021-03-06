using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AdamantiteNunchucks : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Nunchucks");
			Tooltip.SetDefault("Has a chance to confuse struck enemies.");
		}
		public override void SetDefaults()
		{
			item.damage = 47;
            item.melee = true;
			item.width = 34;
			item.height = 56;
			item.useTime = 18;
			item.useAnimation = 18;
            item.channel = true;
			item.useStyle = 5;
			item.knockBack = 7;
            item.value = Item.sellPrice(0, 2, 45, 0);
            item.rare = 5;
			item.UseSound = SoundID.Item1;
            item.crit = 25;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("HardmodeNunchuckSlash");
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if(Main.rand.Next(20) == 0)
            {
                target.AddBuff(BuffID.Confused, 300);
            }
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}