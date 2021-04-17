using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Projectiles.Minions.CrystilianSeek
{
    public class CrystilianSeeker : HoverTurret
    {
        public override void SetStaticDefaults()
        {
            //Display name
            DisplayName.SetDefault("Crystilian Seeker");
            //Amount of frames in minion spritesheet
            Main.projFrames[projectile.type] = 1;
            //Whether minion is a minion or pet
            Main.projPet[projectile.type] = true;

            //Right click targetting feature
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
            //Summon and replace minions when other minions are summoned
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            //Damage reduction for certain npcs
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 14;
            projectile.height = 18;

            //Controls whether minion can deal damage on contact
            projectile.friendly = true;
            //Determines damage type
            projectile.minion = true;
            //Allows minion to go through tiles
            projectile.tileCollide = false;
            projectile.ignoreWater = true;

            //Amount of minion slots this minion occupies
            projectile.minionSlots = 0.5f;
            //Does not despawn on collision with enemies or projectiles
            projectile.penetrate = -1;

            //Minion projectile
            shoot = ModContent.ProjectileType<CrystilianLaser>();
            shootSpeed = 12f;
        }

        //Determines whether the player is dead and therefore cancels the minions.
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            if(player.dead) 
            {
                player.ClearBuff(BuffType<Buffs.CSeekerBuff>());
            }
            if (player.HasBuff(BuffType<Buffs.CSeekerBuff>())) 
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
