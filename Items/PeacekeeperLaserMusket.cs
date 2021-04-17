using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class PeacekeeperLaserMusket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peacekeeper Laser Musket");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.damage = 34;
            item.magic = true;
            item.mana = 10;
            item.width = 82;
            item.height = 30;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = Item.sellPrice(0, 1, 65, 0);
            item.rare = 2;
            item.UseSound = SoundID.Item12;
            item.autoReuse = true;
            item.shootSpeed = 12f;
            item.shoot = 20;
            item.crit = 6;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-15, 0);
        }
    }
}