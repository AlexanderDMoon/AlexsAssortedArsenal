using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class BandofBloodletting : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Band of Bloodletting");
            Tooltip.SetDefault("Very briefly increases mana regeneration after getting hit.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetModPlayer<AAAModPlayer>().BandofBloodlettingEffect = true;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.BrainofCthulhu)
                {
                    if (Main.rand.Next(5) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("BandofBloodletting"));
                }
            }
        }
    }
}