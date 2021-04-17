using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class Everglade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Everglade");
			Tooltip.SetDefault("Throws one of many different magical sparks.");
            Terraria.Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 57;
            item.magic = true;
            item.mana = 6;
            item.width = 62;
            item.height = 54;
            item.useTime = 18;
            item.useAnimation = 18;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 5;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SparkCorruption");
            item.shootSpeed = 18f;
            item.crit = 8;
        }

        private int[] _Everglade = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("SparkCorruption"),
            AlexsAssortedArsenal.Instance.ProjectileType("SparkCrimson"),
            AlexsAssortedArsenal.Instance.ProjectileType("SparkHallow"),
            AlexsAssortedArsenal.Instance.ProjectileType("SparkJungle"),
            AlexsAssortedArsenal.Instance.ProjectileType("SparkOcean"),
            AlexsAssortedArsenal.Instance.ProjectileType("SparkSnow"),
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(_Everglade);
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Blightspark or Bloodspark Wand", 1);
            recipe.AddIngredient(mod, "SparkWandHallow", 1);
            recipe.AddIngredient(mod, "SparkWandJungle", 1);
            recipe.AddIngredient(mod, "SparkWandOcean", 1);
            recipe.AddIngredient(mod, "SparkWandSnow", 1);
            recipe.AddIngredient(mod, "FairiumBar", 5);
            recipe.AddIngredient(ItemID.SoulofLight, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}