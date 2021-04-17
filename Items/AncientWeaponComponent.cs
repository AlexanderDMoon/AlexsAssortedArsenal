using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
	public class AncientWeaponComponent : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Weapon Component");
            Tooltip.SetDefault("A small, cylindrical object with several frayed wires. A lens on the front seems to react to your mana upon touching them." +
                                "\nThe Weaponsmith might be able to do something with this.");
        }

        public override void SetDefaults()
        {
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.width = 42;
            item.height = 40;
            item.maxStack = 1;
            item.rare = 2;
        }
    }
}