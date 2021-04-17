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
    public class LightoftheBrokenDawn : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Light of the Broken Dawn");
            Tooltip.SetDefault("Inflicts the Thermal Sunder debuff for several seconds. \nEnemies near your main target take true damage equal to 45% of the sword's main hit. \n'From the edge of Today to the unknown of Tomorrow, \nthe enemy will always fear the Broken Dawn's Light.'");
        }

        public override void SetDefaults()
        {
            item.damage = 450;
            item.melee = true;
            item.knockBack = 5;
            item.useTime = 17;
            item.useAnimation = 17;
            item.width = 96;
            item.height = 96;
            item.value = Item.sellPrice(0, 15, 0, 0);
            item.rare = 9;
            item.autoReuse = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.crit = 12;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            foreach(NPC n in Main.npc)
            {
                if (n == target || n.townNPC || n.immortal || !n.active)
                    continue;

                if(Vector2.Distance(target.Center, n.Center) <= 16 * 10)
                {
                    int newDamage = crit ? (int)(damage * 0.45f) / 2  + (n.defense / 2) : (int)(damage * 0.45f) + (n.defense / 2);
                    n.StrikeNPC(newDamage, 0f, 0, crit);
                }
            }

            if (Main.rand.Next(5) == 0)
            {
                target.AddBuff(mod.BuffType("ThermalSunder"), 420);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpectralCleaver", 1);
            recipe.AddIngredient(mod, "PhoenixBifrost", 1);
            recipe.AddIngredient(mod, "Flamereaver", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddIngredient(mod, "AetheriumBar", 12);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
