using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Items
{
    public class LightningBugStaff : ModItem
    {
        //Display name and tooltip for weapon
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Bug Staff");
            Tooltip.SetDefault("Summons a Lightning Bug to zap nearby enemies.");

            //Can use anywhere on screen with controller
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
            ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }

        //Constructs weapon behavior and stats
        public override void SetDefaults()
        {
            item.damage = 8;
            item.knockBack = 2;
            item.mana = 10;

            item.width = 54;
            item.height = 54;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = ItemUseStyleID.SwingThrow;

            item.value = Item.buyPrice(0, 0, 0, 1);
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item44;

            item.noMelee = true;
            item.summon = true;
            item.buffType = BuffType<Buffs.LightningBugBuff>();
            item.shoot = ProjectileType<Projectiles.Minions.LightBug.LightningBug>();
        }

        //Creates minion buff and minion spawn location
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.AddBuff(item.buffType, 2);
            position = Main.MouseWorld;

            return true;
        }

        //Sets weapon recipe
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FallenStar, 3);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Lightning Bugs or Fireflies", 5);
            recipe.AddRecipeGroup("AlexsAssortedArsenal:Iron or Lead Bar", 8);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
