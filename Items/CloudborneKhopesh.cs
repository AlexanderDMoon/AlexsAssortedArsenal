using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class CloudborneKhopesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cloudborne Khopesh");
			Tooltip.SetDefault("Striking an enemy grants the Featherfall effect for several seconds.");
		}

        public override void SetDefaults()
        {
            item.damage = 15;
            item.melee = true;
            item.channel = true;
            item.width = 44;
            item.height = 54;
            item.useTime = 56;
            item.useAnimation = 28;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CloudBolt");
            item.shootSpeed = 13f;
            item.crit = 4;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            player.AddBuff(BuffID.Featherfall, 180);
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Harpy)
                {
                    float chance = 0.11f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("CloudborneKhopesh"), 1);
                }
            }
        }
    }
}