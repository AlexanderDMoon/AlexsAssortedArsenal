using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class DeusExOrdos : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deus Ex Ordos");
            Tooltip.SetDefault("Fires a purifying beam of energy that decimates Hallowed, Corrupt and Crimson enemies. \n'Return to dust!' \nLegendary Weapon");
        }

        public override void SetDefaults()
        {
            item.damage = 50;
            item.magic = true;
            item.mana = 4;
            item.width = 98;
            item.height = 40;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = Item.sellPrice(0, 75, 0, 0);
            item.rare = -12;
            item.UseSound = SoundID.Item33;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = mod.ProjectileType("PurityBeam");
            item.crit = 0;
            item.expert = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            {
                type = mod.ProjectileType("PurityBeam");
            }
            return true;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, -6);
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.Retinazer)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }

                if (npc.type == NPCID.Spazmatism)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }

                if (npc.type == NPCID.TheDestroyer)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }

                if (npc.type == NPCID.TheDestroyerBody)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }

                if (npc.type == NPCID.TheDestroyerTail)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }

                if (npc.type == NPCID.SkeletronPrime)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("DeusExOrdos"), 1);
                }
            }
        }
    }
}