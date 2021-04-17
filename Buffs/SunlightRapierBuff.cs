using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Buffs
{
    public class SunlightRapierBuff : ModBuff
    {
        //Description of Lightning Bug Buff
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Sunlight Rapier");
            Description.SetDefault("Attacks nearby enemies.");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        
        //An update function to check whether the player has the buff and properly set buff index.
        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.LightBug.LightningBug>()] > 0) 
            {
                player.buffTime[buffIndex] = 180;
            }
            //else 
            //{
            //    player.DelBuff(buffIndex);
            //    buffIndex--;
            //}
        }
    }
}
