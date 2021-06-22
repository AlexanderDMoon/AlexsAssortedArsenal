using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class CleavingBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cleaving Blade");
            Tooltip.SetDefault("Enemies near your main target take true damage equal to 40% of the sword's main hit.");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 55;
            item.rare = 5;
            item.crit = 4;
            item.knockBack = 4;
            item.useTime = 20;
            item.width = 20;
            item.height = 20;
            item.value = Item.sellPrice(0, 3, 75, 0);
            item.rare = 5;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            foreach(NPC n in Main.npc)
            {
                if (n == target || n.townNPC || n.immortal || !n.active)
                    continue;

                if(Vector2.Distance(target.Center, n.Center) <= 16 * 10)
                {
                    int newDamage = crit ? (int)(damage * 0.4f) / 2  + (n.defense / 2) : (int)(damage * 0.4f) + (n.defense / 2);
                    n.StrikeNPC(newDamage, 0f, 0, crit);
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BreakerBlade);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.CobaltBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BreakerBlade);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.PalladiumBar, 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
