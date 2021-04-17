using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace AlexsAssortedArsenal.Items
{
	public class TempestProw : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tempest Prow");
            Tooltip.SetDefault("Fires three orbs of homing magic that stick to enemies, hitting up to 10 times per orb. \n'From the ashes.' \nLegendary Weapon.");
            Terraria.Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
            item.damage = 44;
            item.magic = true;
            item.mana = 20;
            item.width = 78;
            item.height = 78;
            item.useTime = 28;
            item.useAnimation = 28;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(1, 25, 0, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item8;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("TempestOrb");
            item.shootSpeed = 21f;
            item.crit = 4;
            item.expert = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.DukeFishron)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("TempestProw"), 1);
                }
            }
        }
    }
}