using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class FriendshipNecklace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Friendship Necklace");
            Tooltip.SetDefault("Increases Defense by 1. \nGrants +1 Defense and +1 Life Regen per player on your team.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.value = Item.sellPrice(0, 1, 25, 0);
            item.rare = 2;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            // Default/no team, so no need to update the accessory.
            if (player.team == 0)
                player.statDefense += 1;
                return;

            for (int i = 0; i < Main.maxPlayers; ++i)
            {
                if (Main.player[i].active && !Main.player[i].dead && Main.player[i].team == player.team)
                {
                    player.statDefense += 1;
                    player.lifeRegen += 1;
                }
            }
        }

        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.GoldBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddIngredient(ItemID.PlatinumBar, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}