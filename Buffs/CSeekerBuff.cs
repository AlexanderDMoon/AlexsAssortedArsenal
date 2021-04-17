using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal.Buffs
{
    public class CSeekerBuff : ModBuff
    {
        //Description of Crystillian Seeker Buff
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Crystillian Seeker");
            Description.SetDefault("A crystal being which attacks enemies near you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        
        //An update function to check whether the player has the buff and properly set buff index.
        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.CrystilianSeek.CrystilianSeeker>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else 
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
