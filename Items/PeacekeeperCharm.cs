using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class PeacekeeperCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Peacekeeper Charm");
            Tooltip.SetDefault("Increases Defense by 3. \n'An ancient emblem carried by Peacekeeper monks and explorers of old.'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 0, 7, 50);
            item.rare = 1;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statDefense += 3;
        }

        public override void AddRecipes()
		{
            //Weaponsmith Item;

            //- 1 Sapphire
            //- 1 Silver OR Tungsten Bar
            //- 1 Ancient Coin (Relic identified by Analyzer)
        }
	}
}