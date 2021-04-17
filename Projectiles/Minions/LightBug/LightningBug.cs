using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Projectiles.Minions.LightBug
{
    public class LightningBug : HoverAttacker
    {
        public override void SetStaticDefaults()
        {
            //Display name
            DisplayName.SetDefault("Lightning Bug");
            //Amount of frames in minion spritesheet
            Main.projFrames[projectile.type] = 2;
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
            projectile.width = 40;
            projectile.height = 32;

            //Controls whether minion can deal damage on contact
            projectile.friendly = true;
            //Determines damage type
            projectile.minion = true;
            //Allows minion to go through tiles if false
            projectile.tileCollide = true;
            projectile.ignoreWater = true;

            //Amount of minion slots this minion occupies
            projectile.minionSlots = 1f;
            //Does not despawn on collision with enemies or projectiles
            projectile.penetrate = -1;

            //Minion projectile
            shoot = ModContent.ProjectileType<Minions.LightBug.LightningBugBolt>();
            shootSpeed = 12f;
        }

        public override void CreateDust()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(161, 165, 227), 0.5f);
            Main.dust[dust].velocity *= 0.1f;
            Main.dust[dust].velocity += projectile.velocity * 0.2f;
            Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2, 3);
            Main.dust[dust].noGravity = true;
            Lighting.AddLight(projectile.position, 0.3f, 0.8f, 1f);
        }

        //Determines whether the player is dead and therefore cancels the minions.
        public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            if (player.dead)
            {
                player.ClearBuff(BuffType<Buffs.LightningBugBuff>());
            }
            if (player.HasBuff(BuffType<Buffs.LightningBugBuff>()))
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
