using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class Hellbreaker : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellbreaker");
            Tooltip.SetDefault("Increases mining speed by 35%.");
        }

        public override void SetDefaults()
        {
            item.width = 38;
            item.height = 22;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 3;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.pickSpeed -= .35f;
        }

        public override void AddRecipes()
        {
        }
    }
}