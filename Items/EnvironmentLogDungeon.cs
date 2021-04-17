using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace AlexsAssortedArsenal.Items
{
    public class EnvironmentLogDungeon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Environment Log: The Dungeon");
            Tooltip.SetDefault("I've been warned by the old man to never enter the Dungeon. He said it was filled with dangers" +
                               "\nI could never survive. I heeded this warning, and instead asked him about the Dungeon's interior." +
                               "\nHe said it's filled with animated skeletons capable of tearing adventurers down in seconds, and" +
                               "\nthat some are even capable of casting powerful bolts of water magic. He said that nobody that enters" +
                               "\nwill ever leave, and that his 'Master' makes sure of that. I asked him about his 'Master', and he" +
                               "\nrefused to divulge any details, though he has warned that there are more souls trapped within" +
                               "\nthe world itself, culminating at one point in the earth, and that destroying it will release them." +
                               "\nI hope I don't make that mistake.");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 5;
            item.maxStack = 1;
        }

        public class SoulGlobalNPC : GlobalNPC
        {

            public override void NPCLoot(NPC npc)
            {
                if (npc.type == NPCID.AngryBones)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.AngryBonesBig)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.AngryBonesBigMuscle)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.AngryBonesBigHelmet)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DarkCaster)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.CursedSkull)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DungeonSlime)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DungeonGuardian)
                {
                    if (Main.rand.Next(1) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.BlueArmoredBones)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.BlueArmoredBonesMace)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.BlueArmoredBonesNoPants)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.BlueArmoredBonesSword)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.RustyArmoredBonesAxe)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.RustyArmoredBonesFlail)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.RustyArmoredBonesSword)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.RustyArmoredBonesSwordNoArmor)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.HellArmoredBones)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.HellArmoredBonesSpikeShield)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.HellArmoredBonesMace)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.HellArmoredBonesSword)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.Paladin)
                {
                    if (Main.rand.Next(50) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.Necromancer)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.NecromancerArmored)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DiabolistRed)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DiabolistWhite)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.SkeletonCommando)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.SkeletonSniper)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.TacticalSkeleton)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.GiantCursedSkull)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.BoneLee)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }

                if (npc.type == NPCID.DungeonSpirit)
                {
                    if (Main.rand.Next(100) == 0)
                        Item.NewItem(npc.getRect(), mod.ItemType("EnvironmentLogDungeon"));
                }
            }
        }
    }
}