using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.TownNPC
{
	[AutoloadHead]
    public class Rewarder : ModNPC
    {
        public override bool Autoload(ref string name)
        {
            name = "Rewarder";
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
            npc.height = 46;
            npc.aiStyle = 7;                                    //this is the npc ai style, 7 is Passive Ai
            npc.defense = 25;
            npc.lifeMax = 250;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            if (NPC.downedSlimeKing && Main.expertMode)
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;
        }
        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Leo";
                case 1:
                    return "Matthew";
                case 2:
                    return "Mortimer";
                case 3:
                    return "Robert";
                default:
                    return "John";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
        {
            button = "Buy Rewards";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            int dryadNPC = NPC.FindFirstNPC(NPCID.Dryad);
            if (dryadNPC >= 0)
            {
                shop.item[nextSlot].SetDefaults(3093);          //Herb Bag
                shop.item[nextSlot].shopCustomPrice = new int?(2);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (NPC.downedQueenBee)
            {
                shop.item[nextSlot].SetDefaults(1774);          //Goodie Bag
                shop.item[nextSlot].shopCustomPrice = new int?(5);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(1869);          //Present
                shop.item[nextSlot].shopCustomPrice = new int?(5);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (NPC.downedBoss3)                                //Skeletron
            {
                shop.item[nextSlot].SetDefaults(3085);          //Golden Lock Box
                shop.item[nextSlot].shopCustomPrice = new int?(12);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            shop.item[nextSlot].SetDefaults(mod.ItemType("Tier1AlloyDustBoxItem"));
            shop.item[nextSlot].shopCustomPrice = new int?(15);
            shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("Tier1ElementDustBoxItem"));
            shop.item[nextSlot].shopCustomPrice = new int?(15);
            shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
            nextSlot++;
            if (NPC.downedBoss2)                                //EoW/BoC
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Tier2AlloyDustBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(20);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("Tier2ElementDustBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(20);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Tier3AlloyDustBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(45);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("Tier3ElementDustBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(45);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("Tier4AlloyDustBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(100);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("CellPhonePartsBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(45);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (NPC.downedPlantBoss)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("AnkhBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(135);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("OmegaBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(150);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
            {
                shop.item[nextSlot].SetDefaults(mod.ItemType("CorruptionMimicBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(50);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("CrimsonMimicBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(50);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(mod.ItemType("HallowedMimicBoxItem"));
                shop.item[nextSlot].shopCustomPrice = new int?(50);
                shop.item[nextSlot].shopSpecialCurrency = AdvancedTinkering.RewardCreditID;
                nextSlot++;
            }
        }

        public override string GetChat()
        {
            if (Main.rand.NextFloat() < 0.03f)
            {
                return "You are wondering why I look so different from the others? Well, maybe it's because I was a adventurer too in the past...";
            }
            if (Main.bloodMoon)
            {
                switch (Main.rand.Next(3))
                {
                    case 0:
                        return "Well, sure my rewards won't go anywhere, so could you please kill some zombies before they eat our flesh?";
                    case 1:
                        return "This night is not going well...";
                    case 2:
                        return "Do you think my profession is weird?";
                    default:
                        return "Well, is it reeeally a good time to pick up rewards?";
                }
            }
            int guideNPC = NPC.FindFirstNPC(NPCID.Guide);
            if (guideNPC >= 0 && Main.rand.NextFloat() < 0.20f)
            {
                return "Remeber to pay a visit sometime to " + Main.npc[guideNPC].GivenName + ", he can get pretty lonely after you learn how to survive in this world by yourself.";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Oh, hey brave adventurer, want to buy some well deserved rewards?";
                case 1:
                    return "What you want? Pfft, I'm joking, I only sell rewards, HaHaHa!";
                case 2:
                    return "It's a pretty nice house you have here.";
                case 3:
                    return "I don't need a fancy watch to tell me what time it is. IT'S REWARD TIME!";
                default:
                    return "Oh, hey brave adventurer, want to buy some well deserved rewards?";
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 23;
            knockback = 7f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 39;
            randExtraCooldown = 6;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
        {
            projType = 399;            //Molotov Cocktail
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)  //Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
        {
            multiplier = 6.5f;
            randomOffset = 1f;
        }
    }
}