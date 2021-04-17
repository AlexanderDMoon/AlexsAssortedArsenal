using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class IronMetalligemGreatsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Metalligem Greatsword");
			Tooltip.SetDefault("Throws out a very short-ranged orb that deals more damage to Fire-based enemies.");
		}

        public override void SetDefaults()
        {
            item.damage = 9;
            item.melee = true;
            item.width = 56;
            item.height = 56;
            item.useTime = 21;
            item.useAnimation = 21;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 17, 50);
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AquamarineEnergyOrbAquatana");
            item.shootSpeed = 4f;
            item.crit = 5;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBroadsword, 1);
            recipe.AddIngredient(ItemID.IronBar, 5);
            recipe.AddIngredient(mod, "Aquamarine", 8);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}