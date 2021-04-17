using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.NPCs
{   
    public class WispofLight : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wisp of Light");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Butterfly];
        }

        public override void SetDefaults()
        {
            npc.width = 24;
            npc.height = 22;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 20;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 25f;
            npc.knockBackResist = 0;
            npc.aiStyle = 65;
            npc.noGravity = true;
            aiType = NPCID.Butterfly;
            animationType = NPCID.Butterfly;
        }

        //public override void FindFrame(int frameHeight)
        //{
        //    const int ticksPerFrame = 2;
        //    if (npc.frameCounter++ % ticksPerFrame == 0)
        //    {
        //        // update frame
        //    }
        //}

        public override void AI()
        {
            Dust.NewDust(npc.position + npc.velocity, npc.width, npc.height, 164, npc.velocity.X * 0.5f, npc.velocity.Y * 0.5f);
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedMechBossAny && !Main.dayTime)
                return SpawnCondition.OverworldHallow.Chance * 0.60f;
            return 0;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = 164;
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
        }

        public override void NPCLoot()
        {
            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.SoulofLight, Main.rand.Next(1, 3));

            if (Main.rand.Next(100) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BestiarySoulWisps"), 1);
        }
    }
}