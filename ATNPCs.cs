using Microsoft.Xna.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace AdvancedTinkering
{
    class ATNPCs: GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.expertMode)
            {
                //-------------------------------------Misc-------------------------------------\\

                if (
                    npc.type == 21 ||                           //Basic Skeleton
                    npc.type == 31 ||                           //Angry Bones
                    npc.type == 32 ||                           //Dark Caster
                    npc.type == 34 ||                           //Cursed Skull
                    npc.type == 35 ||                           //Skeletron Head
                    npc.type == 36 ||                           //Skeletron Hand
                    npc.type == 39 ||                           //Bone Serpent Head
                    npc.type == 40 ||                           //Bone Serpent Body
                    npc.type == 41 ||                           //Bone Serpent Tail
                    npc.type == 44 ||                           //Undead Miner
                    npc.type == 45 ||                           //Tim
                    npc.type == 77 ||                           //Armored Skeleton
                    npc.type == 110 ||                          //Skeleton Archer
                    npc.type == 127 ||                          //Skeletron Prime Head
                    npc.type == 128 ||                          //Skeletron Prime Cannon
                    npc.type == 129 ||                          //Skeletron Prime Saw
                    npc.type == 130 ||                          //Skeletron Prime Vice
                    npc.type == 131 ||                          //Skeletron Prime Laser
                    npc.type == 167 ||                          //Undead Viking
                    npc.type == 172 ||                          //Rune Wizard
                    npc.type == 197 ||                          //Armored Viking
                    npc.type == 201 ||                          //Headache Skeleton
                    npc.type == 202 ||                          //Misassembled Skeleton
                    npc.type == 203 ||                          //Pantless Skeleton
                    npc.type == 269 ||                          //Rusty Armored Bones Axe
                    npc.type == 270 ||                          //Rusty Armored Bones Flail
                    npc.type == 271 ||                          //Rusty Armored Bones Chainmail
                    npc.type == 272 ||                          //Rusty Armored Bones Sword
                    npc.type == 273 ||                          //Blue Armored Bones Muscle
                    npc.type == 274 ||                          //Blue Armored Bones Club
                    npc.type == 275 ||                          //Blue Armored Bones Big Helmet
                    npc.type == 276 ||                          //Blue Armored Bones Sword
                    npc.type == 277 ||                          //Hell Armored Bones Axe
                    npc.type == 278 ||                          //Hell Armored Bones Shield
                    npc.type == 279 ||                          //Hell Armored Bones Mace
                    npc.type == 280 ||                          //Hell Armored Bones Sword
                    npc.type == 281 ||                          //Ragged Caster 1
                    npc.type == 282 ||                          //Ragged Caster 2
                    npc.type == 283 ||                          //Necromancer 1
                    npc.type == 284 ||                          //Necromancer 2
                    npc.type == 285 ||                          //Diabolist 1
                    npc.type == 286 ||                          //Diabolist 2
                    npc.type == 287 ||                          //Bone Lee
                    npc.type == 289 ||                          //Giant Cursed Skull
                    npc.type == 291 ||                          //Skeleton Sniper
                    npc.type == 292 ||                          //Tactical Skeleton
                    npc.type == 293 ||                          //Skeleton Commando
                    npc.type == 294 ||                          //Angry Bones Big
                    npc.type == 295 ||                          //Angry Bones Big Muscle
                    npc.type == 296 ||                          //Angry Bones Big Helmet
                    npc.type == 322 ||                          //Groom Skeleton
                    npc.type == 323 ||                          //Astronaut Skeleton
                    npc.type == 324 ||                          //Martian Skeleton
                    npc.type == 449 ||                          //Expert Basic Skeleton
                    npc.type == 450 ||                          //Expert Headache Skeleton
                    npc.type == 451 ||                          //Expert Misassembled Skeleton
                    npc.type == 452 ||                          //Expert Pantless Skeleton
                    npc.type == 453 ||                          //Skeleton Merchant
                    npc.type == 481                             //Hoplite
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        Item.NewItem(npc.getRect(), 154);       //Bone
                    }

                    if (Main.rand.NextFloat() < 0.005f)
                    {
                        Item.NewItem(npc.getRect(), 2192);      //Bone Welder
                    }
                }

                if (
                    npc.type == 26 ||                           //Goblin Peon
                    npc.type == 27 ||                           //Goblin Thief
                    npc.type == 28 ||                           //Goblin Warrior
                    npc.type == 29 ||                           //Goblin Sorcerer
                    npc.type == 73 ||                           //Goblin Scout
                    npc.type == 105 ||                          //Goblin Tinkerer (Bound)
                    npc.type == 107 ||                          //Goblin Tinkerer
                    npc.type == 111 ||                          //Goblin Archer
                    npc.type == 471                             //Goblin Summoner
                    )
                {
                    if (Main.rand.NextFloat() < 0.15f)
                    {
                        Item.NewItem(npc.getRect(), 362);       //Tattered Cloth
                    }
                    else if (Main.rand.NextFloat() < 0.66f && !Main.hardMode)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Shadowspark"));
                    }
                    else
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Shadowspark"));
                    }
                }

                if (
                    npc.type == 31 ||                           //Angry Bones
                    npc.type == 294 ||                          //Angry Bones Big
                    npc.type == 295 ||                          //Angry Bones Big Muscle
                    npc.type == 296                             //Angry Bones Big Helmet

                    )
                {
                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CursedNaginata"));
                    }
                }
                if (
                    npc.type == 34                              //Cursed Skull
                    )
                {
                    if (Main.rand.NextFloat() < 0.03f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("ServantSkullStaff"));
                    }
                }

                if (
                    npc.type == 294 ||                          //Angry Bones Big
                    npc.type == 295                             //Angry Bones Big Muscle
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("RedSkeletalWarriorBreastplate"));
                    }
                }
                if (
                    npc.type == 296                             //Angry Bones Big Helmet
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        int choice = Main.rand.Next(2);
                        if (choice == 0)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("RedSkeletalWarriorHelmet"));
                        }
                        else if (choice == 1)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("RedSkeletalWarriorGreaves"));
                        }
                    }
                }
                if (
                    npc.type == 77                              //Armored Skeleton
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        int choice = Main.rand.Next(3);
                        if (choice == 0)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("BlueSkeletalWarriorHelmet"));
                        }
                        else if (choice == 1)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("BlueSkeletalWarriorBreastplate"));
                        }
                        else if (choice == 2)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("BlueSkeletalWarriorGreaves"));
                        }
                    }
                }
                if (
                    npc.type == 110                             //Skeleton Archer
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        int choice = Main.rand.Next(3);
                        if (choice == 0)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("GreenSkeletalRangerHeadgear"));
                        }
                        else if (choice == 1)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("GreenSkeletalRangerChainmail"));
                        }
                        else if (choice == 2)
                        {
                            Item.NewItem(npc.getRect(), mod.ItemType("GreenSkeletalRangerLeggings"));
                        }
                    }
                }

                if (NPC.downedPlantBoss &&
                    npc.type == 156                             //Red Devil
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Elucidator"));
                    }
                }

                if (
                    npc.type == 361                             //Frog
                    )
                {
                    if (Main.rand.NextFloat() < 0.05f)
                    {
                        Item.NewItem(npc.getRect(), 2423);      //Frog Leg
                    }
                }

                if (
                    npc.type == 445                             //Gold Frog
                    )
                {
                    if (Main.rand.NextFloat() < 0.25f)
                    {
                        Item.NewItem(npc.getRect(), 2423);      //Frog Leg
                    }
                }

                //-------------------------------------Reward Credits-------------------------------------\\

                if (
                    npc.type == 36                              //Skeletron Hand
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(2, 4));
                }
                if (
                    npc.type >= 128 &&                          //Prime Cannon
                    npc.type <= 131                             //Prime Laser
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(5, 7));
                }
                if (
                    npc.type == 439                             //Lunatic Cultist
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(2, 4));
                }
                if (
                    npc.type == 564                             //Dark Mage T1
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(8, 13));
                }
                if (
                    npc.type == 565                             //Dark Mage T3
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(10, 15));
                }
                if (
                    npc.type == 576                             //Ogre T2
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(18, 26));
                }
                if (
                    npc.type == 577                             //Ogre T3
                    )
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("RewardCredit"), Main.rand.Next(20, 28));
                }

                //-------------------------------------Shark-------------------------------------\\

                if (
                    npc.type == 332 ||                          //Sharkron 1
                    npc.type == 333                             //Sharkron 2
                    )
                {
                    if (Main.rand.NextFloat() < 0.10f)
                    {
                        Item.NewItem(npc.getRect(), 319);       //Shark Fin
                    }
                }

                if (
                    npc.type == 65 ||                           //Shark
                    npc.type == 332 ||                          //Sharkron 1
                    npc.type == 333 ||                          //Sharkron 2
                    npc.type == 542 ||                          //Sand Shark
                    npc.type == 543 ||                          //Bone Biter
                    npc.type == 544 ||                          //Flesh Reaver
                    npc.type == 545                             //Crystal Thresher
                    )
                {
                    if (Main.rand.NextFloat() < 0.666f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SharkTooth"));
                    }
                }

                //-------------------------------------Bunny-------------------------------------\\

                if (
                    npc.type == 46                              //Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.0133f)
                    {
                        Item.NewItem(npc.getRect(), 243);       //Bunny Hood
                    }
                }

                if (
                    npc.type == 303                             //Slime Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.5f)
                    {
                        Item.NewItem(npc.getRect(), 23);        //Gel
                    }
                }


                if (
                    npc.type == 337                             //Christmas Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.0133f)
                    {
                        Item.NewItem(npc.getRect(), 588);       //Santa Hat
                        Item.NewItem(npc.getRect(), 589);       //Santa Shirt
                        Item.NewItem(npc.getRect(), 590);       //Santa Pants
                    }
                }

                if (
                    npc.type == 540                             //Party Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.0133f)
                    {
                        Item.NewItem(npc.getRect(), 3732);      //Party Hat
                    }
                }
                
                if (
                    npc.type == 443                             //Gold Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.25f)
                    {
                        Item.NewItem(npc.getRect(), 243);       //Bunny Hood
                    }

                    if (Main.rand.NextFloat() < 0.25f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("DiseasterBunnyHood"));
                    }

                    if (Main.rand.NextFloat() < 0.25f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CorruptBunnyHood"));
                    }

                    if (Main.rand.NextFloat() < 0.25f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimtaneBunnyHood"));
                    }
                }

                if (
                    npc.type == 2121                            //Crimtane Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.0133f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimtaneBunnyHood"));
                    }
                }

                if (
                    npc.type == 47                              //Corrupt Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.0133f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CorruptBunnyHood"));
                    }
                }

                //-------------------------------------Immunity Accessories-------------------------------------\\

                if (
                    npc.type == 163 ||                          //Black Recluse
                    npc.type == 238 ||                          //Black Recluse Wall
                    npc.type == 530 ||                          //Sand Poacher
                    npc.type == 531                             //Sand Poacher Wall
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Antivenom"));
                    }
                }

                if (
                    npc.type == 101 ||                          //Clinger
                    npc.type == 525                             //Vile Ghoul
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CursedWater"));
                    }
                }

                if (
                    npc.type == 281 ||                          //Ragged Caster 1
                    npc.type == 282                             //Ragged Caster 2
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("EyeDrops"));
                    }
                }

                if (
                    npc.type == 268 ||                          //Ichor Sticker
                    npc.type == 526                             //Tainted Ghoul
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("IchorWater"));
                    }
                }

                if (
                    npc.type == 568 ||                          //Wither Beast Tier 2
                    npc.type == 569                             //Wither Beast Tier 3
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("OldArmorScroll"));
                    }
                }

                if (
                    npc.type == 578                             //Etherian Lightning Bug
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("OldWeaponScroll"));
                    }
                }

                if (
                    npc.type == 439 ||                          //Lunatic Cultist
                    npc.type == 440 ||                          //Ancient Cultist
                    npc.type == 471                             //Goblin Summoner
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("ShadowWater"));
                    }
                }

                if (
                    npc.type == 163 ||                          //Black Recluse
                    npc.type == 238                             //Black Recluse Wall
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SpiderScissors"));
                    }
                }

                if (
                    npc.type == 576 ||                          //Ogre Tier 2
                    npc.type == 577                             //Ogre Tier 3
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("TissueBox"));
                    }
                }

                if (
                    npc.type == 147 ||                          //Ice Slime
                    npc.type == 150 ||                          //Ice Bat
                    npc.type == 169 ||                          //Ice Elemental
                    npc.type == 184 ||                          //Spiked Ice Slime
                    npc.type == 206 ||                          //Ice Merman
                    npc.type == 243 ||                          //Ice Golem
                    npc.type == 345                             //Ice Queen
                    )
                {
                    if (Main.rand.NextFloat() < 0.02f)
                    {
                        Item.NewItem(npc.getRect(), 1921);      //Hand Warmer
                    }
                }

                //-------------------------------------Arachnid Meat-------------------------------------\\

                if (
                    npc.type == 239 ||                          //Blood Crawler
                    npc.type == 240                             //Blood Crawler Wall
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimsonArachnidMeat"));
                    }
                }

                if (
                    npc.type == 366 ||                          //Black Scorpion
                    npc.type == 367 ||                          //Scorpion
                    npc.type == 530 ||                          //Sand Poacher
                    npc.type == 531                             //Sand Poacher Wall
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("DesertArachnidMeat"));
                    }
                }

                if (
                    npc.type == 236 ||                          //Jungle Creeper
                    npc.type == 237                             //Jungle Creeper Wall
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("JungleArachnidMeat"));
                    }
                }

                if (
                    npc.type == 164 ||                          //Wall Creeper
                    npc.type == 165 ||                          //Wall Creeper Wall
                    npc.type == 163 ||                          //Black Recluse
                    npc.type == 238                             //Black Recluse Wall
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundArachnidMeat"));
                    }
                }

                //-------------------------------------Bird Meat-------------------------------------\\

                if (
                        npc.type == 168                         //Corrupt Penguin
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CorruptionBirdMeat"));
                    }
                }

                if (
                        npc.type == 470                         //Vicious Penguin
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimsonBirdMeat"));
                    }
                }

                if (
                        npc.type == 442                         //Gold Bird
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("GoldBirdMeat"));
                    }
                }

                if (
                        npc.type == 74 ||                       //Bird
                        npc.type == 297 ||                      //Blue Jay
                        npc.type == 298 ||                      //Cardinal
                        npc.type == 362 ||                      //Mallard Duck
                        npc.type == 363 ||                      //Mallard Duck Flying
                        npc.type == 364 ||                      //Duck
                        npc.type == 365                         //Duck Flying
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalBirdMeat"));
                    }
                }

                if (
                        npc.type == 48                          //Harpy
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SkyBirdMeat"));
                    }
                }

                if (
                        npc.type == 148 ||                      //Penguin 1
                        npc.type == 149                         //Penguin 2
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SnowBirdMeat"));
                    }
                }

                //-------------------------------------Bunny Meat-------------------------------------\\

                if (
                        npc.type == 47                          //Corrupt Bunny
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CorruptBunnyMeat"));
                    }
                }

                if (
                        npc.type == 464                         //Crimtane Bunny
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimtaneBunnyMeat"));
                    }
                }

                if (
                    npc.type == 443                             //Gold Bunny
                    )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("GoldBunnyMeat"));
                    }
                }

                if (
                        npc.type == 46 ||                       //Bunny
                        npc.type == 303 ||                      //Slime Bunny
                        npc.type == 337 ||                      //Christmas Bunny
                        npc.type == 540                         //Party Bunny
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalBunnyMeat"));
                    }
                }

                //-------------------------------------Crustacean Meat-------------------------------------\\

                if (
                        npc.type == 67                          //Crab
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalCrustaceanMeat"));
                    }
                }

                if (
                        npc.type == 257 ||                      //Anomura Fungus
                        npc.type == 494 ||                      //Crawdad 1
                        npc.type == 495                         //Crawdad 2
                        )
                {
                    if (Main.rand.NextFloat() < 0.33f)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundCrustaceanMeat"));
                    }
                }

                //-------------------------------------Fish Meat-------------------------------------\\

                if (
                        npc.type == 57 ||                       //Corrupt Goldfish
                        npc.type == 543                         //Bone Biter
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CorruptionFishMeat"));
                    }
                }

                if (
                        npc.type == 241 ||                      //Blood Feeder
                        npc.type == 465 ||                      //Crimtane Goldfish
                        npc.type == 544                         //Flesh Reaver
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("CrimsonFishMeat"));
                    }
                }

                if (
                        npc.type == 542                         //Sand Shark
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("DesertFishMeat"));
                    }
                }

                if (
                        npc.type == 545                         //Crystal Thresher
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("HallowFishMeat"));
                    }
                }

                if (
                        npc.type == 58 ||                       //Piranha
                        npc.type == 157                         //Arapaima
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("JungleFishMeat"));
                    }
                }

                if (
                        npc.type == 55 ||                       //Goldfish
                        npc.type == 230                         //Walking Goldfish
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalFishMeat"));
                    }
                }

                if (
                        npc.type == 224                         //Flying Fish
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SkyFishMeat"));
                    }
                }

                if (
                        npc.type == 206                         //Icy Merman
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SnowFishMeat"));
                    }
                }

                if (
                        npc.type == 58 ||                       //Piranha
                        npc.type == 102                         //Angler Fish
                        )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundFishMeat"));
                    }
                }

                //-------------------------------------Frog Meat-------------------------------------\\

                if (
                    npc.type == 445                            //Gold Frog
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("GoldFrogMeat"));
                    }
                }

                if (
                    npc.type == 361                            //Frog
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("JungleFrogMeat"));
                    }
                }

                //-------------------------------------Insect Meat-------------------------------------\\

                if (
                    npc.type == 69 ||                          //Antlion
                    npc.type == 508 ||                         //Antlion Charger
                    npc.type == 509                            //Antlion Swarmer
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("DesertInsectMeat"));
                    }
                }

                if (
                    npc.type == 444 ||                         //Gold Butterfly//
                    npc.type == 446 ||                         //Gold Grasshopper
                    npc.type == 448                            //Gold Worm
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("GoldInsectMeat"));
                    }
                }

                if (
                    npc.type == 358                            //Lightning Bug
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("HallowInsectMeat"));
                    }
                }

                if (
                    npc.type == 211 ||                         //Bee
                    npc.type == 222 ||                         //Queen Bee
                    npc.type == 232                            //Honey Hornet
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("HoneyInsectMeat"));
                    }
                }

                if (
                    npc.type == 42 ||                          //Hornet
                    npc.type == 176 ||                         //Moss Hornet
                    npc.type == 219 ||                         //Lac Beetle
                    npc.type == 231 ||                         //Fatty Hornet
                    npc.type == 232 ||                         //Honey Hornet
                    npc.type == 233 ||                         //Leafy Hornet
                    npc.type == 234 ||                         //Spikey Hornet
                    npc.type == 235 ||                         //Stingy Hornet
                    npc.type == 485 ||                         //Grubby
                    npc.type == 486 ||                         //Sluggy
                    npc.type == 487                            //Buggy
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("JungleInsectMeat"));
                    }
                }

                if (
                    npc.type == 355 ||                         //Firefly
                    npc.type == 356 ||                         //Butterfly
                    npc.type == 377                            //Grasshopper
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalInsectMeat"));
                    }
                }

                if (
                    npc.type == 218                            //Cyan Beetle
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("SnowInsectMeat"));
                    }
                }

                if (
                    npc.type == 217 ||                         //Cochineal Beetle
                    npc.type == 258 ||                         //Mushi Ladybug
                    npc.type == 357 ||                         //Worm
                    npc.type == 374 ||                         //Truffle Worm
                    npc.type == 375 ||                         //Truffle Worm Fleeing
                    npc.type == 484 ||                         //Enchanted Nightcrawler
                    npc.type == 496 ||                         //Giant Shelly
                    npc.type == 497                            //Giant Shelly Spinning
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundInsectMeat"));
                    }
                }

                //-------------------------------------Mollusc Meat-------------------------------------\\

                if (
                    npc.type == 122                            //Gastropod
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("HallowMolluscMeat"));
                    }
                }

                if (
                    npc.type == 359 ||                         //Snail
                    npc.type == 360                            //Glowing Snail
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundMolluscMeat"));
                    }
                }

                //-------------------------------------Rodent Meat-------------------------------------\\

                if (
                    npc.type == 299 ||                         //Squirrel
                    npc.type == 538                            //Red Squirrel
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("NormalRodentMeat"));
                    }
                }

                if (
                    npc.type == 300                            //Mouse
                    )
                {
                    if (Main.rand.NextFloat() < 0.33)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("UndergroundRodentMeat"));
                    }
                }
            }
        }

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }

        public bool WarpedJavelin = false;
        public bool TrueWarpedJavelin = false;
        public bool TerraCurse;

        public override void ResetEffects(NPC npc)
        {
            WarpedJavelin = false;
            TrueWarpedJavelin = false;
            TerraCurse = false;
        }

        public override void SetDefaults(NPC npc)
        {
            npc.buffImmune[mod.BuffType("Buffs.WarpedJavelin")] = npc.buffImmune[BuffID.BoneJavelin];
            npc.buffImmune[mod.BuffType("Buffs.TrueWarpedJavelin")] = npc.buffImmune[BuffID.BoneJavelin];
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (WarpedJavelin)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int WarpedJavelinCount = 0;
                for (int i = 0; i < 1000; i++)
                {
                    Projectile p = Main.projectile[i];
                    if (p.active && (p.type == mod.ProjectileType("WarpedJavelinBProjectile") || p.type == mod.ProjectileType("WarpedJavelinEProjectile")) && p.ai[0] == 1f && p.ai[1] == npc.whoAmI)
                    {
                        WarpedJavelinCount++;
                    }
                }
                npc.lifeRegen -= WarpedJavelinCount * 2 * 3;
                if (damage < WarpedJavelinCount * 3)
                {
                    damage = WarpedJavelinCount * 3;
                }
            }

            if (TrueWarpedJavelin)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                int TrueWarpedJavelinCount = 0;
                for (int i = 0; i < 1000; i++)
                {
                    Projectile p = Main.projectile[i];
                    if (p.active && (p.type == mod.ProjectileType("TrueWarpedJavelinBProjectile") || p.type == mod.ProjectileType("TrueWarpedJavelinEProjectile")) && p.ai[0] == 1f && p.ai[1] == npc.whoAmI)
                    {
                        TrueWarpedJavelinCount++;
                    }
                }
                npc.lifeRegen -= TrueWarpedJavelinCount * 2 * 5;
                if (damage < TrueWarpedJavelinCount * 5)
                {
                    damage = TrueWarpedJavelinCount * 5;
                }
            }

            if (TerraCurse)
            {
                if (npc.lifeRegen > 0)
                {
                    npc.lifeRegen = 0;
                }
                npc.lifeRegen -= 90;
                if (damage < 15)
                {
                    damage = 15;
                }
            }
        }
    }
}