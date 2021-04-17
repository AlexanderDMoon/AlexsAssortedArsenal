using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AquamarinePhaseblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquamarine Phaseblade");
			Tooltip.SetDefault("");
		}

        public override void SetDefaults()
        {
            item.damage = 21;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 0, 54, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item15;
            item.autoReuse = false;
            item.crit = 0;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteoriteBar, 15);
            recipe.AddIngredient(mod, "Aquamarine", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}