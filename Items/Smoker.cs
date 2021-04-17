using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Smoker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smoker");
            Tooltip.SetDefault("Uses flares for ammo. \n'Bad for your lungs. And your neighbor's lungs. And whoever you fire this thing at.'");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.ranged = true;
            item.width = 42;
            item.height = 24;
            item.useTime = 17;
            item.useAnimation = 17;
            item.useStyle = 5;
            item.holdStyle = 1;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 1, 15, 0);
            item.rare = 1;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = 163;
            item.crit = 0;
            item.useAmmo = AmmoID.Flare;
        }

        public override void HoldItem(Player player)
        {
            Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
            player.itemLocation.X = player.Center.X + -18f;
            player.itemLocation.Y = player.Bottom.Y + -30f;
        }

        public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
        {
            glowstick = true;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 600);
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(3, -3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlareGun, 1);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Iron or Lead Bar", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}