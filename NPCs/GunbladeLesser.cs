using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.NPCs
{   
    public class GunbladeLesser : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Gunblade Elemental");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.EnchantedSword];
        }

        public override void SetDefaults()
        {
            npc.width = 42;
            npc.height = 52;
            npc.damage = 20;
            npc.defense = 15;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 25f;
            npc.knockBackResist = 0.60f;
            npc.aiStyle = 23;
            aiType = NPCID.EnchantedSword;
            animationType = NPCID.EnchantedSword;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedBoss1)
                return SpawnCondition.Cavern.Chance * 0.035f;
            return 0;
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.SilverCoin, (6));

            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("UnusualMetalChunk"), 1);

            if (Main.rand.Next(100) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BestiaryElementalGunbladeLesser"), 1);

            if (Main.rand.Next(100) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BestiaryArsenalElemental"), 1);
        }

        //public override void HitEffect(int hitDirection, double damage)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        int dustType = 62;
        //        int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
        //        Dust dust = Main.dust[dustIndex];
        //        dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
        //        dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
        //        dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
        //    }
        //}
    }
}