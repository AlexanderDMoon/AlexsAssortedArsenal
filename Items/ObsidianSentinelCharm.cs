using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class ObsidianSentinelCharm : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Obsidian Sentinel Charm");
            Tooltip.SetDefault("Increases armour penetration by 12. \nIncreased movement speed by 10%. \nIncreases Magic and Minion damage by 7%. \nGrants two additional Minion slots and one Sentry slot.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 48;
            item.value = Item.sellPrice(0, 4, 75, 0);
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.armorPenetration += 12;
            player.moveSpeed += 0.10f;
            player.maxMinions += 2;
            player.maxTurrets += 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SapphireToothNecklace", 1);
            recipe.AddIngredient(mod, "ObsidianAmulet", 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 12);
            recipe.AddIngredient(ItemID.SoulofLight, 3);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.Hellforge);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}