using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.NPCs
{   
    public class BlueDungeonMimic : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Dungeon Mimic");
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BigMimicHallow];
        }

        public override void SetDefaults()
        {
            npc.width = 48;
            npc.height = 42;
            npc.damage = 115;
            npc.defense = 40;
            npc.lifeMax = 4500;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 25f;
            npc.knockBackResist = 0;
            npc.aiStyle = 87;
            aiType = NPCID.BigMimicHallow;
            animationType = NPCID.BigMimicHallow;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (NPC.downedPlantBoss)
                return SpawnCondition.Dungeon.Chance * 0.01f;
            return 0;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            for (int i = 0; i < 10; i++)
            {
                int dustType = 59;
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
                Item.NewItem(npc.getRect(), ItemID.GoldCoin, 4);

            if (Main.rand.Next(75) == 0)
                Item.NewItem(npc.getRect(), mod.ItemType("BestiaryDungeonMimics"), 1);

            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.Ectoplasm, Main.rand.Next(3, 5));

            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.GreaterHealingPotion, 14);

            if (Main.rand.Next(1) == 0)
                Item.NewItem(npc.getRect(), ItemID.GreaterManaPotion, 14);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.Keybrand, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.WispinaBottle, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.MagnetSphere, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.ShadowbeamStaff, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.SpectreStaff, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //   Item.NewItem(npc.getRect(), ItemID.InfernoFork, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.RocketLauncher, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.RifleScope, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //    Item.NewItem(npc.getRect(), ItemID.SniperRifle, 1);

            //if (Main.rand.NextFloat() < .0450f)
            //   Item.NewItem(npc.getRect(), ItemID.TacticalShotgun, 1);
        }
    }
}