using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace AlexsAssortedArsenal.Items.Accessories.Movement {
    public class DiscordCloak : ModItem {
        const int MAXSTEPS = 13 * 16; // tile length
        const uint FRAMETIMEOUT = 30;

        internal enum Direction {
            Left = 1,
            Right = -1
        }
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Cloak of Discord");
        }

        public override void SetDefaults() {
            item.width = 32;
            item.height = 32;

            item.accessory = true;
            item.rare = Terraria.ID.ItemRarityID.Blue; // never specified in discord, so like, change if u want lol
        }
        internal static void TryDash(ref Player player, Direction direction) {
            if (player.dashDelay > 0)
                return;

            int maxSteps = 0;
            Rectangle hitbox = player.Hitbox;
            do {
                int directed = maxSteps * (int)direction;
                Rectangle adjusted = new Rectangle(hitbox.X - directed, hitbox.Y, hitbox.Width, hitbox.Height);

                if (!Collision.SolidTiles((int)(adjusted.X / 16f), (int)((adjusted.X + (float)adjusted.Width) / 16f), (int)(adjusted.Y / 16f), (int)((adjusted.Y + (float)adjusted.Height - 8) / 16f))) {
                    goto BEHAVIOR;
                }

                TELEPORT:
                player.Teleport(adjusted.Location.ToVector2(), 8);
                player.immuneTime = 20;
                player.AddBuff(Terraria.ID.BuffID.ChaosState, 120); // 120 is 1.5 seconds

                Main.TeleportEffect(hitbox, 3);
                break;

                BEHAVIOR:
                if(directed % 16 == 0)
                    Dust.NewDustPerfect(adjusted.Center.ToVector2(), Terraria.ID.DustID.AmethystBolt);

                if (System.Math.Abs(maxSteps) == MAXSTEPS - 1) // we'll always be one off :(
                    goto TELEPORT;

                maxSteps++; // decrement once;
            } while (maxSteps < MAXSTEPS);
        }

        public override void UpdateEquip(Player player) {
            player.GetModPlayer<CloakModPlayer>().hasCloak = true;
        }
    }
}
