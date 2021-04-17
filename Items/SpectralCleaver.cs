using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class SpectralCleaver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectral Cleaver");
			Tooltip.SetDefault("Striking an enemy grants you Invisibility, Featherfall and rapid life regen for several seconds. \nHas a chance to slow enemies and inflict a moderate bleed debuff. \nEnemies near your main target take true damage equal to 42% of the sword's main hit.");
		}

        public override void SetDefaults()
        {
            item.damage = 85;
            item.melee = true;
            item.channel = true;
            item.width = 76;
            item.height = 94;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = Item.sellPrice(0, 2, 30, 0);
            item.rare = 9;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 12;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(mod.BuffType("SunderedSoul"), 420);
            }
            player.AddBuff(mod.BuffType("Apparition"), 600);

            foreach (NPC n in Main.npc)
            {
                if (n == target || n.townNPC || n.immortal || !n.active)
                    continue;

                if (Vector2.Distance(target.Center, n.Center) <= 16 * 10)
                {
                    int newDamage = crit ? (int)(damage * 0.42f) / 2 + (n.defense / 2) : (int)(damage * 0.42f) + (n.defense / 2);
                    n.StrikeNPC(newDamage, 0f, 0, crit);
                }
            }
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CleavingBlade", 1);
            recipe.AddIngredient(ItemID.Keybrand, 1);
            recipe.AddIngredient(ItemID.SpectreBar, 18);
            recipe.AddTile(TileID.AdamantiteForge);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}