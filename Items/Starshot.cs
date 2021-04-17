using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Starshot : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Starshot");
            Tooltip.SetDefault("Fires one of four High-Velocity Lunar Pillar bullets. \n'Break through.' \nLegendary Weapon.");
        }

        public override void SetDefaults()
        {
            item.damage = 210;
            item.ranged = true;
            item.width = 42;
            item.height = 22;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = Item.sellPrice(3, 0, 0, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item40;
            item.autoReuse = false;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("HighVelocityNebula");
            item.crit = 24;
            item.useAmmo = AmmoID.Bullet;
            item.expert = true;
        }

        private int[] _starShot = new int[]
        {
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityNebula"),
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocitySolar"),
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityStardust"),
            AlexsAssortedArsenal.Instance.ProjectileType("HighVelocityVortex")
        };

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            type = Main.rand.Next(_starShot);
            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, 0);
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.MoonLordCore)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("Starshot"), 1);
                }
            }
        }
    }
}