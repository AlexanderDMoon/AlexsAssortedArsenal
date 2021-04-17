using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.NPCs
{   
    public class GunpowderLesser : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lesser Gunpowder Elemental");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 22;
            npc.damage = 17;
            npc.defense = 10;
            npc.lifeMax = 55;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 25f;
            npc.knockBackResist = 0.22f;
            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedQueenBee)
                return SpawnCondition.Overworld.Chance * 0.15f;
            return 0;
        }

        public override void NPCLoot()
        {

            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.SilverCoin, (8));

            if (Main.rand.Next(1) == 0)
            Item.NewItem(npc.getRect(), mod.ItemType("GunpowderCore"), 1);

            //if (Main.rand.Next(75) == 0)
            //Item.NewItem(npc.getRect(), mod.ItemType("BestiaryLesserGunpowderElemental"), 1);
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = 4;
                int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
                Dust dust = Main.dust[dustIndex];
                dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
                dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
                dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
            }
        }
    }
}