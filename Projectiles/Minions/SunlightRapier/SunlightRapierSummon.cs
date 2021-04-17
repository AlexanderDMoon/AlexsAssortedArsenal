using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Projectiles.Minions.SunlightRapier
{
    public class SunlightRapierSummon : HoverAttacker
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunlight Rapier");
            Main.projPet[projectile.type] = true;
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.width = 46;
            projectile.height = 50;
            projectile.friendly = true;
            projectile.minion = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.minionSlots = 0f;
            projectile.penetrate = -1;
            shootSpeed = 12f;
        }

        public override void CreateDust()
        {
            int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 158, 0f, 0f, 100, new Color(0, 0, 0), 0.5f);
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
                player.ClearBuff(BuffType<Buffs.SunlightRapierBuff>());
            }
            if (player.HasBuff(BuffType<Buffs.SunlightRapierBuff>()))
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
