using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class AbsoluteZero : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Absolute Zero");
            Tooltip.SetDefault("Fires a massive spread of high-velocity Cryoshot bullets when using Musket Shot as ammo. \n'The bruise-your-own-forehead mega-revolver guaranteed to put a hilariously large hole in someone's face. \nOr to just... blow it off completely.' \nLegendary Weapon");
        }

        public override void SetDefaults()
        {
            item.damage = 31;
            item.ranged = true;
            item.width = 64;
            item.height = 36;
            item.useTime = 27;
            item.useAnimation = 27;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 25;
            item.value = Item.sellPrice(1, 0, 0, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item38;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("HighVelocityCryoshot");
            item.crit = 8;
            item.useAmmo = AmmoID.Bullet;
            item.expert = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.Bullet)
            {
                type = mod.ProjectileType("HighVelocityCryoshot");
            }

            int numberProjectiles = 16 + Main.rand.Next(0);
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(18));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-20, 0);
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.IceQueen)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                    Item.NewItem(npc.getRect(), mod.ItemType("AbsoluteZero"), 1);
                }
            }
        }
    }
}