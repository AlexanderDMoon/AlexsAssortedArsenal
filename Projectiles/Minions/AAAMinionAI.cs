using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Projectiles.Minions
{
    public abstract class AAAMinionAI : ModProjectile
    {
        //Method to run AI on minions
        public override bool PreAI()
        {
            CheckActive();
            Behavior();

            return true;
        }

        public abstract void CheckActive();

        public abstract void Behavior();
    }
}