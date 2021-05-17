using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items.Accessories.Movement {
    public class CloakModPlayer : ModPlayer { // Class name should explain itself.
        internal bool hasCloak;
        internal uint cloakTimer;

        public override void ResetEffects() {
            hasCloak = false;
            cloakTimer--;
        }
    }
}
