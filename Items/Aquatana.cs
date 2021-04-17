using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Aquatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aquatana");
			Tooltip.SetDefault("Throws out a short-ranged orb that deals more damage to Fire-based enemies.");
		}

        public override void SetDefaults()
        {
            item.damage = 23;
            item.melee = true;
            item.width = 52;
            item.height = 62;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AquamarineEnergyOrbAquatana");
            item.shootSpeed = 12f;
            item.crit = 5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddIngredient(mod, "Aquamarine", 8);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Demonite or Crimtane Bar", 12);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}