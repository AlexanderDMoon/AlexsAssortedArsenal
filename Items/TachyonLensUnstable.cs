using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class TachyonLensUnstable : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unstable Tachyon Lens");
            Tooltip.SetDefault("Use to return to your previous point of death. \n'You can catch a glimpse of what seems to be a previous timeline as you look through the lens; \nYou don't immediately recognize the location, but you can't help but feel like you'd have met your demise there.'");
        }

        public override void SetDefaults()
        {
            item.width = 50;
            item.height = 38;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTurn = true;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 0, 75, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item6;
            item.maxStack = 10;
            item.consumable = true;
            item.autoReuse = false;
        }
        
        public override bool UseItem(Player player)
        {
            player.position = player.GetModPlayer<AAAModPlayer>().lastDeathPos;
            return true;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(0, -15);
        }

        public class SoulGlobalNPC : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.WallofFlesh)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("TachyonLensUnstable"), Main.rand.Next(1, 3));
                }
            }
        }
    }
}