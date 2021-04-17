using System;
using AlexsAssortedArsenal.Items;
using AlexsAssortedArsenal.Projectiles;
using AlexsAssortedArsenal.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace ExampleMod.NPCs
{
    // [AutoloadHead] and npc.townNPC are extremely important and absolutely both necessary for any Town NPC to work at all.
    [AutoloadHead]
    public class Weaponsmith : ModNPC
    {
        public override string Texture => "AlexsAssortedArsenal/NPCs/Weaponsmith";

        public override string[] AltTextures => new[] { "AlexsAssortedArsenal/NPCs/Weaponsmith" };

        public override bool Autoload(ref string name)
        {
            name = "Weaponsmith";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            // DisplayName automatically assigned from .lang files, but the commented line below is the normal approach.
            // DisplayName.SetDefault("Example Person");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 10;
            npc.defense = 15;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.ArmsDealer;
        }

        //public override void HitEffect(int hitDirection, double damage)
        //{
        //    int num = npc.life > 0 ? 1 : 5;
        //    for (int k = 0; k < num; k++)
        //    {
        //        Dust.NewDust(npc.position, npc.width, npc.height, ModContent.DustType<Sparkle>());
        //    }
        //}

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                foreach (Item item in player.inventory)
                {
                    if (item.type == (ModContent.ItemType<AncientWeaponComponent>()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        // Example Person needs a house built out of ExampleMod tiles. You can delete this whole method in your townNPC for the regular house conditions.
        //public override bool CheckConditions(int left, int right, int top, int bottom)
        //{
        //    int score = 0;
        //    for (int x = left; x <= right; x++)
        //    {
        //        for (int y = top; y <= bottom; y++)
        //        {
        //            int type = Main.tile[x, y].type;
        //            if (type == ModContent.TileType<ExampleBlock>() || type == ModContent.TileType<ExampleChair>() || type == ModContent.TileType<ExampleWorkbench>() || type == ModContent.TileType<ExampleBed>() || type == ModContent.TileType<ExampleDoorOpen>() || type == ModContent.TileType<ExampleDoorClosed>())
        //           {
        //                score++;
        //            }
        //            if (Main.tile[x, y].wall == ModContent.WallType<ExampleWall>())
        //            {
        //                score++;
        //            }
        //        }
        //    }
        //    return score >= (right - left) * (bottom - top) / 2;
        //}

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(13))
            {
                case 0:
                    return "Adri";
                case 1:
                    return "Stevie";
                case 2:
                    return "Fletcher";
                case 3:
                    return "Bailey";
                case 4:
                    return "Colt";
                case 5:
                    return "Berett";
                case 6:
                    return "Zwei";
                case 7:
                    return "Morgan";
                case 8:
                    return "Remmy";
                case 9:
                    return "Marley";
                case 10:
                    return "Winny";
                case 11:
                    return "Lee";
                default:
                    return "Pistol";
            }
        }

        public override void FindFrame(int frameHeight)
        {
            /*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
        }

        public override string GetChat()
        {
            //int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            //if (partyGirl >= 0 && Main.rand.NextBool(4))
            //{
            //    return "Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?";
            //}
            switch (Main.rand.Next(6))
            {
                case 0:
                    return "Hey. Need somethin'?";
                case 1:
                    return "*They hum absentmindedly for a moment before noticing you.* \n \n Oh, hey. What do you need?";
                case 2:
                    return "I know my way around these Peacekeeper relics. Just bring me any old pieces of weaponry and I'll put somethin' real nice together for you.";
                case 3:
                    return "Yes, it's just my gun in my pants. But I am still happy to see you.";
                case 4:
                    return "If you happen to be missin' somethin', I might have it in stock. For a price, of course. Gotta make a livin' somehow, right?";
                //case 2:
                //   {
                //        // Main.npcChatCornerItem shows a single item in the corner, like the Angler Quest chat.
                //        Main.npcChatCornerItem = ModContent.ItemType<Datapad>();
                //        return $"Have you filled in that [i:{ModContent.ItemType<Datapad>()}], yet?";
                //    }
                default:
                    return "*They grunt in acknowledgement and wave at you.*";
            }
        }

        /* 
		// Consider using this alternate approach to choosing a random thing. Very useful for a variety of use cases.
		// The WeightedRandom class needs "using Terraria.Utilities;" to use
		public override string GetChat()
		{
			WeightedRandom<string> chat = new WeightedRandom<string>();
			int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
			if (partyGirl >= 0 && Main.rand.NextBool(4))
			{
				chat.Add("Can you please tell " + Main.npc[partyGirl].GivenName + " to stop decorating my house with colors?");
			}
			chat.Add("Sometimes I feel like I'm different from everyone else here.");
			chat.Add("What's your favorite color? My favorite colors are white and black.");
			chat.Add("What? I don't have any arms or legs? Oh, don't be ridiculous!");
			chat.Add("This message has a weight of 5, meaning it appears 5 times more often.", 5.0);
			chat.Add("This message has a weight of 0.1, meaning it appears 10 times as rare.", 0.1);
			return chat; // chat is implicitly cast to a string. You can also do "return chat.Get();" if that makes you feel better
		}
		*/

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            if (Main.LocalPlayer.HasItem(ModContent.ItemType<AncientWeaponComponent>()))
                button = "Build " + Lang.GetItemNameValue(ModContent.ItemType<PeacekeeperLaserMusket>());
            else if (Main.LocalPlayer.HasItem(ModContent.ItemType<AncientCoins>()))
                button = "Build " + Lang.GetItemNameValue(ModContent.ItemType<PeacekeeperCharm>());
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                // We want 3 different functionalities for chat buttons, so we use HasItem to change button 1 between a shop and upgrade action.
                if (Main.LocalPlayer.HasItem(ModContent.ItemType<AncientWeaponComponent>()))
                {
                    Main.PlaySound(SoundID.Item37); // Reforge/Anvil sound
                    Main.npcChatText = $"Now THAT is a musket! It's been a while since I've pieced together one of those old relics. Give it a whirl for me, yeah?";
                    int AncientWeaponComponent = Main.LocalPlayer.FindItem(ModContent.ItemType<AncientWeaponComponent>());
                    Main.LocalPlayer.inventory[AncientWeaponComponent].TurnToAir();
                    Main.LocalPlayer.QuickSpawnItem(ModContent.ItemType<PeacekeeperLaserMusket>());
                    return;
                }

                if (Main.LocalPlayer.HasItem(ModContent.ItemType<AncientCoins>()))
                {
                    Main.PlaySound(SoundID.Item37); // Reforge/Anvil sound
                    Main.npcChatText = $"Only one of these seem to be intact enough to restore. Here you go; I'll keep the rest for study. \n \nIf you find any more, bring 'em to me, friend.";
                    int AncientCoins = Main.LocalPlayer.FindItem(ModContent.ItemType<AncientCoins>());
                    Main.LocalPlayer.inventory[AncientCoins].TurnToAir();
                    Main.LocalPlayer.QuickSpawnItem(ModContent.ItemType<PeacekeeperCharm>());
                    return;
                }

                shop = true;
            }
            //else
            //{
            //    // If the 2nd button is pressed, open the inventory...
            //    Main.playerInventory = true;
            //    // remove the chat window...
            //    Main.npcChatText = "";
            //    // and start an instance of our UIState.
            //    ModContent.GetInstance<ExampleMod>().ExamplePersonUserInterface.SetState(new UI.ExamplePersonUI());
            //    // Note that even though we remove the chat window, Main.LocalPlayer.talkNPC will still be set correctly and we are still technically chatting with the npc.
            //}
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.WandofSparking);
            //shop.item[nextSlot].shopCustomPrice = 1;
            nextSlot++;
            
            if (Main.bloodMoon)
            {
                shop.item[nextSlot].SetDefaults(ItemID.BladedGlove);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BloodyMachete);
                nextSlot++;
            }
            if (NPC.downedSlimeKing)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SlimeStaff);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Katana);
                nextSlot++;
            }
            if (NPC.downedBoss1)
            {
                shop.item[nextSlot].SetDefaults(ItemID.ChainKnife);
                shop.item[nextSlot].shopCustomPrice = 20000;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Rally);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.FlareGun);
                nextSlot++;
            }
            if (NPC.downedBoss2)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Musket);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Vilethorn);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BallOHurt);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.TheUndertaker);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.CrimsonRod);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.TheRottedFork);
                nextSlot++;
            }
            if (NPC.downedBoss3)
            {
                shop.item[nextSlot].SetDefaults(ItemID.WaterBolt);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BookofSkulls);
                nextSlot++;
            }
            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Boomstick);
                nextSlot++;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Arkhalis);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BeamSword);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Marrow);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.BreakerBlade);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.ClockworkAssaultRifle);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.LaserRifle);
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(ItemID.NimbusRod);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.MedusaHead);
                nextSlot++;
            }
            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Uzi);
                shop.item[nextSlot].shopCustomPrice = 750000;
                nextSlot++;
            }

            //    // Here is an example of how your npc can sell items from other mods.
            //    var modSummonersAssociation = ModLoader.GetMod("SummonersAssociation");
            //    if (modSummonersAssociation != null)
            //    {
            //        shop.item[nextSlot].SetDefaults(modSummonersAssociation.ItemType("BloodTalisman"));
            //        nextSlot++;
            //    }
            //
            //    if (!Main.LocalPlayer.GetModPlayer<ExamplePlayer>().examplePersonGiftReceived && ModContent.GetInstance<ExampleConfigServer>().ExamplePersonFreeGiftList != null)
            //    {
            //        foreach (var item in ModContent.GetInstance<ExampleConfigServer>().ExamplePersonFreeGiftList)
            //        {
            //            if (item.IsUnloaded)
            //                continue;
            //            shop.item[nextSlot].SetDefaults(item.Type);
            //            shop.item[nextSlot].shopCustomPrice = 0;
            //            shop.item[nextSlot].GetGlobalItem<ExampleInstancedGlobalItem>().examplePersonFreeGift = true;
            //            nextSlot++;
            //            // TODO: Have tModLoader handle index issues.
            //        }
        }

        public override void NPCLoot()
        {
            //Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Armor.ExampleCostume>());
        }

        // Make this Town NPC teleport to the King and/or Queen statue when triggered.
        public override bool CanGoToStatue(bool toQueenStatue)
        {
            return true;
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.Bullet;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}