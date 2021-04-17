using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class MattockDungeon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dungeon Mattock");
			Tooltip.SetDefault("Has a chance to extract uncommon treasures when mining Silt and Slush. \nHas a chance to dig up Bones.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
            item.melee = true;
			item.width = 30;
			item.height = 34;
			item.useTime = 16;
			item.useAnimation = 16;
            item.pick = 50;
			item.useStyle = 1;
            item.useTurn = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.crit = 0;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Pickaxe", 1);
            recipe.AddIngredient(ItemID.Bone, 30);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Gold or Platinum Bar", 3);
            recipe.AddIngredient(ItemID.WaterCandle, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}