using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class ArmadanTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Armadan Tome");
            Tooltip.SetDefault("Fires a magic bolt.");
            Terraria.Item.staff[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.magic = true;
            item.mana = 5;
            item.width = 28;
            item.height = 28;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = Item.sellPrice(0, 0, 33, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = 123;
            item.shootSpeed = 26f;
            item.crit = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Vilethorn or Crimson Rod", 1);
            recipe.AddIngredient(ItemID.Feather, 5);
            recipe.AddIngredient(ItemID.SunplateBlock, 10);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}