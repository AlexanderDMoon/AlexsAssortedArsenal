using static AlexsAssortedArsenal.Items.Accessories.Movement.DiscordCloak;

namespace AlexsAssortedArsenal.Items.Accessories.Movement {
    static class CloakHook {
        internal static void Load() {
            On.Terraria.Player.KeyDoubleTap += CloakHooker; // vanilla method i want to hook into!!!!!
        }

        private static void CloakHooker(On.Terraria.Player.orig_KeyDoubleTap orig, Terraria.Player self, int keyDir) {
            orig.Invoke(self, keyDir); // call the original method, then run my code

            if (self.HasBuff(Terraria.ID.BuffID.ChaosState)) 
                return;
            if (!self.GetModPlayer<CloakModPlayer>().hasCloak)
                return;

            if (keyDir == 3) // checking if double tap is left
                TryDash(ref self, Direction.Left);

            if (keyDir == 2) // checking if double tap is right
                TryDash(ref self, Direction.Right);
        }
    }
}
