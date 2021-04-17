using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class TitaniumMusketBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium Musket Ball");
            Tooltip.SetDefault("Pierces up to three enemies and has a chance to inflict Confusion.");
		}

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.consumable = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 0, 7);
            item.rare = 3;
            item.shoot = mod.ProjectileType("TitaniumMusketBall");
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(30) == 0)
            {
                target.AddBuff(BuffID.Confused, 300);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitaniumBar, 1);
            recipe.AddIngredient(ItemID.MusketBall, 50);
            recipe.AddTile(TileID.AdamantiteForge);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }
    }
}