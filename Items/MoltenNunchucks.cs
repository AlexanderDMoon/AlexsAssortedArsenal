using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MoltenNunchucks : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Nunchucks");
            Tooltip.SetDefault("Has a chance to confuse struck enemies.");
        }
		public override void SetDefaults()
		{
			item.damage = 30;
            item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 24;
			item.useAnimation = 24;
            item.channel = true;
			item.useStyle = 5;
			item.knockBack = 6;
            item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.crit = 20;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.shoot = mod.ProjectileType("NunchuckSlash");
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
            recipe.AddIngredient(ItemID.HellstoneBar, 18);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}