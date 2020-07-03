using AlexsAssortedArsenal.Items;
using AlexsAssortedArsenal.NPCs;
using AlexsAssortedArsenal.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using Terraria.Utilities;
using static Terraria.ModLoader.ModContent;

namespace AlexsAssortedArsenal
{  
    public class AAAGlobalNPC : GlobalNPC
    {
        public override bool CheckDead(NPC npc)
        {
            if (!NPC.downedMechBossAny && (npc.type == 134 || npc.type == 125 || npc.type == 126 || npc.type == 127))
                Main.NewText("Lost souls wander the Hallow and World Evil...", Color.LightGreen);

            if (!NPC.downedBoss1 && (npc.type == 4))
                Main.NewText("Living revolvers haunt the caverns below you...", Color.LightGreen);

            if (!NPC.downedQueenBee && (npc.type == 222))
                Main.NewText("Piles of gunpowder spring to life...", Color.LightGreen);

            return true;
        }

        public override void NPCLoot(NPC npc)
        {
            if (npc.type == mod.NPCType("BlueDungeonMimic"))
            {
                var dropChooser = new WeightedRandom<int>();
                dropChooser.Add(ItemID.Keybrand);
                dropChooser.Add(ItemID.WispinaBottle);
                dropChooser.Add(ItemID.MagnetSphere);
                dropChooser.Add(ItemID.ShadowbeamStaff);
                dropChooser.Add(ItemID.SpectreStaff);
                dropChooser.Add(ItemID.InfernoFork);
                dropChooser.Add(ItemID.RocketLauncher);
                dropChooser.Add(ItemID.RifleScope);
                dropChooser.Add(ItemID.SniperRifle);
                dropChooser.Add(ItemID.TacticalShotgun);
                int choice = dropChooser;
                Item.NewItem(npc.getRect(), choice);
            }
        }
    }  
}