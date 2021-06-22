using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class TachyonMirror : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tachyon Mirror");
            Tooltip.SetDefault("Use to return to your previous point of death. \n'Seems significantly more stable than the regular lens. Maybe it'll stick with you, this time around.'");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 38;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 5, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item6;
            item.maxStack = 10;
            item.consumable = false;
            item.autoReuse = false;
        }
        
        public override bool UseItem(Player player)
        {
            player.position = player.GetModPlayer<AAAModPlayer>().lastDeathPos;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TachyonLensUnstable", 1);
            recipe.AddIngredient(ItemID.MagicMirror, 1);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TachyonLensUnstable", 1);
            recipe.AddIngredient(ItemID.IceMirror, 1);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}