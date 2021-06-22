using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Zatoichi : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zatoichi");
            Tooltip.SetDefault("Right-click to preform a damaging dash. \nEnemies killed by the dash have a chance to drop a heart. \nLegendary Weapon");
            //Certain weapons, like this one, are "Legendary Weapons", meaning they're rare and have a special gimmick/effect/whatever that makes them stand out.

            //For this weapon in particular, It'll have some passive and active effects:

            //When held, the sword gives the player the Blackout debuff. This is a reference to Zatoichi himself, who was described as a "blind swordsman".

            //Right-clicking lets the player blink forward like the Cloak of Discord. Enemies that get "hit" by the blink have an increased chance to drop one of those lil hearts that heal for 20 HP.
                //This attack could probably also have an increased crit chance? Like +15% or something.
                //Use the same dusts as the Master Ninja Gear's dash, and the usual sword-swing sound.

            //The blink could have a cooldown of 5 seconds.
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.damage = 12;
            item.width = 62;
            item.height = 60;
            item.useTime = 18;
            item.useAnimation = 18;
            item.knockBack = 3;
            item.value = Item.sellPrice(0, 20, 0, 0);
            item.rare = -12; //This combined with ModifyTooltips allows me to give it a Rainbow rarity while leaving out the "Expert Mode" tooltip that items w/ the Rainbow rarity have.
            item.autoReuse = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.crit = 8;
            item.expert = true; //This bit is required for Rainbow rarity to work, iirc.
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            tooltips.RemoveAll(l => l.mod == "Terraria" && l.Name == "Expert");
        }

        public class SoulGlobalNPC : GlobalNPC //I'm honestly not entirely sure if this is the best way to go about dropping items, but it's worked for everything so far, so I'm not too bothered, tbph.
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.KingSlime)
                {
                    float chance = 0.01f;
                    if (Main.expertMode) chance *= 1.5f;
                    if (Main.rand.NextFloat() < chance)
                        Item.NewItem(npc.getRect(), mod.ItemType("Zatoichi"), 1);
                }
            }
        }
    }
}
