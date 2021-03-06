using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class BoltcasterAquamarine : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aquamarine Boltcaster");
            Tooltip.SetDefault("Fires light-speed bolts that deal more damage to Fire-based enemies. \nRight-click to zoom out.");
        }

        public override void SetDefaults()
        {
            item.damage = 28;
            item.ranged = true;
            item.width = 80;
            item.height = 26;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("LightBoltAquamarine");
            item.crit = 4;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void HoldItem(Player player)
        {
            player.scope = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly)
            {
                type = mod.ProjectileType("LightBoltAquamarine");
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-12, -2);
        }

        public override void AddRecipes()
        {

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PhasebolterAquamarine", 1);
            recipe.AddIngredient(ItemID.CrystalShard, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}