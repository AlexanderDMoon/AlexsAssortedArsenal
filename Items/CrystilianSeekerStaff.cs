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
    public class CrystilianSeekerStaff : ModItem
    {
        //Display name and tooltip for weapon
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystilian Seeker Staff");
            Tooltip.SetDefault("Summons a Crystilian Seeker to fight on your behalf.");

            //Can use anywhere on screen with controller
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
            ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }

        //Constructs weapon behavior and stats
        public override void SetDefaults()
        {
            item.damage = 24;
            item.summon = true;
            item.mana = 10;
            item.width = 26;
            item.height = 26;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 2;
            item.value = Item.buyPrice(0, 1, 20, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item44;
            item.autoReuse = true;
            item.noMelee = true;
            item.buffType = BuffType<Buffs.CSeekerBuff>();
            item.shoot = ProjectileType<Projectiles.Minions.CrystilianSeek.CrystilianSeeker>();
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
            recipe.AddIngredient(ItemID.ImpStaff, 1);
            recipe.AddIngredient(mod, "CrystilianShard", 10);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
