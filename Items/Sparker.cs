using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Sparker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sparker");
            Tooltip.SetDefault("Shoots sparks. \nUses Gel for ammo.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 60;
            item.height = 26;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 0, 0, 10);
            item.rare = 0;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 7f;
            item.shoot = mod.ProjectileType("Spark");
            item.crit = 1;
            item.useAmmo = AmmoID.Gel;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(4, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddIngredient(ItemID.CopperBar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 25);
            recipe.AddIngredient(ItemID.Torch, 3);
            recipe.AddIngredient(ItemID.TinBar, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}