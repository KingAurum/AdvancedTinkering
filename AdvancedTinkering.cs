using Microsoft.Xna.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameContent.UI;
using Terraria.GameInput;
using Terraria.Localization;

namespace AdvancedTinkering
{
    public class ItemChanges : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.ChangeToolDamageType)
            {
                if (item.type == 2776 || item.type == 3523)     //Vortex Pickaxe/Hamaxe
                {
                    item.melee = false;
                    item.ranged = true;
                }
                if (item.type == 1506 || item.type == 1507 ||   //Spectre Pickaxe/Hamaxe
                    item.type == 2781 || item.type == 3524)     //Nebula Pickaxe/Hamaxe
                {
                    item.melee = false;
                    item.magic = true;
                }
                if (item.type == 3466 || item.type == 3525)     //Stardust Pickaxe/Hamaxe
                {
                    item.melee = false;
                    item.summon = true;
                }
            }
            if (Config.ThrowingDamageBoomerang)
            {
                if (item.type == 55 ||                          //Enchanted Boomerang
                    item.type == 119 ||                         //Flamarang
                    item.type == 191 ||                         //Thorn Chakram
                    item.type == 284 ||                         //Wooden Boomerang
                    item.type == 561 ||                         //Light Disc
                    item.type == 670 ||                         //Ice Boomerang
                    item.type == 1122 ||                        //Possessed Hatchet
                    item.type == 1324 ||                        //Bananarang
                    item.type == 1513 ||                        //Paladin's Hammer
                    item.type == 1825 ||                        //Bloody Machete
                    item.type == 1918 ||                        //Fruitcake Chakram
                    item.type == 3030)                          //Flying Knife
                {
                    item.melee = false;
                    item.thrown = true;
                }
            }

            if (item.type == 1223 || item.type == 1197)     //Orichalcum Waraxe/Chainsaw
            {
                item.axe = 19;
            }
            if (item.type == 992 || item.type == 384)       //Mythril Waraxe/Chainsaw
            {
                item.axe = 18;
            }
            if (item.type == 1222 || item.type == 1190)     //Palladium Waraxe/Chainsaw
            {
                item.axe = 17;
            }
            if (item.type == 991 || item.type == 383)       //Cobalt Waraxe/Chainsaw
            {
                item.axe = 16;
            }
            if (item.type == 217)                           //Molten Hamaxe
            {
                item.axe = 15;
            }
            if (item.type == 204)                           //Meteor Hamaxe
            {
                item.axe = 14;
            }
            if (item.type == 799 || item.type == 45)        //Blood Lust Cluster/Waraxe of the Night
            {
                item.axe = 13;
            }

            if (item.type == 1922)                          //Coal
            {
                item.maxStack = 999;
                item.value = Item.sellPrice(0, 0, 0, 18);
            }

            if (item.type == 42 ||                          //Shuriken
                item.type == 161 ||                         //Spiky Ball
                item.type == 166 ||                         //Bomb
                item.type == 167 ||                         //Dynamite
                item.type == 168 ||                         //Grenade
                item.type == 279 ||                         //Throwing Knive
                item.type == 287 ||                         //Poisoned Knive
                item.type == 1130 ||                        //Beenade
                item.type == 3094 ||                        //Javelin
                item.type == 3378 ||                        //Bone Javelin
                item.type == 3379)                          //Bone Throwing Knife
            {
                item.ammo = item.type;
                item.notAmmo = false;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            if (item.type == 374)                           //Cobalt Breastplate
            {
                player.thrownCrit += 3;
            }

            if (item.type == 1208)                          //Palladium Breastplate
            {
                player.minionDamage += 0.03f;
                player.thrownDamage += 0.03f;
                player.thrownCrit += 2;
            }
            if (item.type == 1209)                          //Palladium Leggings
            {
                player.minionDamage += 0.02f;
                player.thrownDamage += 0.02f;
                player.thrownCrit += 1;
            }

            if (item.type == 379)                           //Mythril Breastplate
            {
                player.minionDamage += 0.05f;
                player.thrownDamage += 0.05f;
            }
            if (item.type == 380)                           //Mythril Leggings
            {
                player.thrownCrit += 3;
            }

            if (item.type == 1213)                          //Orichalcum Breastplate
            {
                player.thrownCrit += 6;
            }

            if (item.type == 403)                           //Adamantite Breastplate
            {
                player.minionDamage += 0.06f;
                player.thrownDamage += 0.06f;
            }
            if (item.type == 404)                           //Adamantite Leggings
            {
                player.thrownCrit += 4;
            }

            if (item.type == 1218)                          //Titanium Breastplate
            {
                player.minionDamage += 0.04f;
                player.thrownDamage += 0.04f;
                player.thrownCrit += 3;
            }
            if (item.type == 1219)                          //Titanium Leggings
            {
                player.minionDamage += 0.03f;
                player.thrownDamage += 0.03f;
                player.thrownCrit += 3;
            }

            if (item.type == 551)                           //Hallowed Plate Mail
            {
                player.thrownCrit += 7;
            }
            if (item.type == 552)                           //Hallowed Greaves
            {
                player.minionDamage += 0.07f;
                player.thrownDamage += 0.07f;
            }

            if (item.type == 1004)                          //Chlorophyte Plate Mail
            {
                player.minionDamage += 0.05f;
                player.thrownDamage += 0.05f;
                player.thrownCrit += 7;
            }
            if (item.type == 1005)                          //Chlorophyte Greaves
            {
                player.thrownCrit += 8;
            }
        }

        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost95)
            {
                return Main.rand.NextFloat() >= .05f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost90)
            {
                return Main.rand.NextFloat() >= .10f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost85)
            {
                return Main.rand.NextFloat() >= .15f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost80)
            {
                return Main.rand.NextFloat() >= .20f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost75)
            {
                return Main.rand.NextFloat() >= .25f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost70)
            {
                return Main.rand.NextFloat() >= .30f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost65)
            {
                return Main.rand.NextFloat() >= .35f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost60)
            {
                return Main.rand.NextFloat() >= .40f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost55)
            {
                return Main.rand.NextFloat() >= .45f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).ammoCost50)
            {
                return Main.rand.NextFloat() >= .50f;
            }
            return true;
        }

        public override bool ConsumeItem(Item item, Player player)
        {
            if (player.GetModPlayer<ATPlayer>(mod).itemCost95)
            {
                return Main.rand.NextFloat() >= .05f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost90)
            {
                return Main.rand.NextFloat() >= .10f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost85)
            {
                return Main.rand.NextFloat() >= .15f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost80)
            {
                return Main.rand.NextFloat() >= .20f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost75)
            {
                return Main.rand.NextFloat() >= .25f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost70)
            {
                return Main.rand.NextFloat() >= .30f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost65)
            {
                return Main.rand.NextFloat() >= .35f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost60)
            {
                return Main.rand.NextFloat() >= .40f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost55)
            {
                return Main.rand.NextFloat() >= .45f;
            }
            if (player.GetModPlayer<ATPlayer>(mod).itemCost50)
            {
                return Main.rand.NextFloat() >= .50f;
            }
            return true;
        }
    }

    public class ProjectileChanges : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.ThrowingDamageBoomerang)
            {
                if (projectile.type == 6 ||                     //Enchanted Boomerang
                    projectile.type == 19 ||                    //Flamarang
                    projectile.type == 33 ||                    //Thorn Chakram
                    projectile.type == 52 ||                    //Wooden Boomerang
                    projectile.type == 106 ||                   //Light Disc
                    projectile.type == 113 ||                   //Ice Boomerang
                    projectile.type == 182 ||                   //Possessed Hatchet
                    projectile.type == 272 ||                   //Bananarang
                    projectile.type == 301 ||                   //Paladin's Hammer
                    projectile.type == 320 ||                   //Bloody Machete
                    projectile.type == 333 ||                   //Fruitcake Chakram
                    projectile.type == 491)                     //Flying Knife
                {
                    projectile.melee = false;
                    projectile.thrown = true;
                }
            }
        }
    }

    public class AdvancedTinkering : Mod
    {
        internal static AdvancedTinkering instance;

        public static ModHotKey ToggleAppHotKey;

        public AdvancedTinkering()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }

        public static int RewardCreditID;

        public override void Load()
        {
            Config.Load();

            instance = this;

            RewardCreditID = CustomCurrencyManager.RegisterCurrency(new RewardCredit(ItemType("RewardCredit"), 999L));

            ToggleAppHotKey = RegisterHotKey("Toggle App Phone", "P");

            ToggleAppHotKey = null;
            instance = null;
        }
        /*
        public override void UpdateMusic(ref int music)
        {
            if (Main.myPlayer != -1 && !Main.gameMenu)
            {
                if (Main.player[Main.myPlayer].active && Main.player[Main.myPlayer].GetModPlayer<MyPlayer>(this).ZoneGoldenBiome) //this makes the music play only in Golden Biome
                {
                    music = this.GetSoundSlot(SoundType.Music, "Sounds/Music/GoldenBiomeMusic");
                }
            }
        }
        */
        public override void AddRecipeGroups()
        {
            //-------------------------------------Misc-------------------------------------\\

            if (RecipeGroup.recipeGroupIDs.ContainsKey("IronBar"))
            {
                int index = RecipeGroup.recipeGroupIDs["IronBar"];
                RecipeGroup group = RecipeGroup.recipeGroups[index];
                group.ValidItems.Add(ItemType("SteelBarItem"));
                group.ValidItems.Add(ItemType("StainlessSteelBarItem"));
            }

            if (RecipeGroup.recipeGroupIDs.ContainsKey("Wood"))
            {
                int index = RecipeGroup.recipeGroupIDs["Wood"];
                RecipeGroup group = RecipeGroup.recipeGroups[index];
                group.ValidItems.Add(2260);     //Dynasty Wood
                group.ValidItems.Add(1729);     //Spooky Wood
                group.ValidItems.Add(ItemType("PineWoodBlockItem"));
                group.ValidItems.Add(ItemType("GoldenWoodBlockItem"));
            }

            RecipeGroup g = new RecipeGroup(() => Lang.misc[37] + " DD2 Sentry Accessory", new int[]
            {
            3809,                               //Apprentice's Scarf
            3810,                               //Squire's Shield
            3811,                               //Huntress's Buckler
            3812,                               //Monk's Belt
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:DD2SentryAccessory", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Sawtooth Shark", new int[]
            {
            2342,                               //Sawtooth Shark
            ItemType("CobaltSawtoothShark"),
            ItemType("PalladiumSawtoothShark"),
            ItemType("MythrilSawtoothShark"),
            ItemType("OrichalcumSawtoothShark"),
            ItemType("AdamantiteSawtoothShark"),
            ItemType("TitaniumSawtoothShark"),
            ItemType("HallowedSawtoothShark"),
            ItemType("ChlorophyteSawtoothShark"),
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:SawtoothShark", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Tier 3 Forge", new int[]
            {
            ItemType("Tier3aForgeItem"),
            ItemType("Tier3bForgeItem"),
            ItemType("Tier3cForgeItem"),
            ItemType("Tier3dForgeItem"),
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:Tier3Forge", g);

            //-------------------------------------Sand-------------------------------------\\

            if (RecipeGroup.recipeGroupIDs.ContainsKey("Sand"))
            {
                int index = RecipeGroup.recipeGroupIDs["Sand"];
                RecipeGroup group = RecipeGroup.recipeGroups[index];
                group.ValidItems.Add(3275);     //Hardened Crimsand Block
                group.ValidItems.Add(3274);     //Hardened Ebonsand Block
                group.ValidItems.Add(3338);     //Hardened Pearlsand Block
                group.ValidItems.Add(3271);     //Sandstone Block
                group.ValidItems.Add(3277);     //Crimsandstone Block
                group.ValidItems.Add(3276);     //Ebonsandstone Block
                group.ValidItems.Add(3339);     //Pearlsandstone Block
            }

            g = new RecipeGroup(() => Lang.misc[37] + " Sand Block", new int[]
            {
            169,                                //Sand Block
            1246,                               //Crimsand Block
            370,                                //Ebonsand Block
            408,                                //Pearlsand Block
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:SandBlock", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Hardened Sand Block", new int[]
            {
            3272,                               //Hardened Sand Block
            3275,                               //Hardened Crimsand Block
            3274,                               //Hardened Ebonsand Block
            3338,                               //Hardened Pearlsand Block
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:HardenedSandBlock", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Sandstone Block", new int[]
            {
            3271,                               //Sandstone Block
            3277,                               //Crimsandstone Block
            3276,                               //Ebonsandstone Block
            3339,                               //Pearlsandstone Block
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:SandstoneBlock", g);

            //-------------------------------------Animal Skin-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Animal Skin", new int[]
            {
            2281,                               //Tiger Skin
            2282,                               //Leopard Skin
            2283,                               //Zebra Skin
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:AnimalSkin", g);

            //-------------------------------------Arachnid Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Desert Arachnid", new int[]
            {
            2156,                               //Black Scorpion 
            2157,                               //Scorpion
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:DesertArachnid", g);

            //-------------------------------------Bird Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Normal Bird", new int[]
            {
            2015,                               //Bird
            2016,                               //Blue Jay
            2017,                               //Cardinal
            2123,                               //Duck
            2122,                               //Mallard Duck
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:NormalBird", g);

            //-------------------------------------Bunny Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Normal Bunny", new int[]
            {
            2019,                               //Bunny
            2479,                               //Bunnyfish
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:NormalBunny", g);

            //-------------------------------------Fish Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Corruption Fish", new int[]
            {
            2318,                               //Ebonkoi
            2454,                               //Cursedfish
            2457,                               //Eater of Plankton
            2485,                               //Infected Scabbardfish
            2330,                               //Purple Clubberfish
            3210,                               //Toxikarp
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:CorruptionFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Crimson Fish", new int[]
            {
            2305,                               //Crimson Tigerfish
            2319,                               //Hemopiranha
            2477,                               //Bloody Manowar
            2463,                               //Ichorfish
            3211,                               //Bladetongue
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:CrimsonFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Hallow Fish", new int[]
            {
            2317,                               //Chaos Fish
            2307,                               //Princess Fish
            2310,                               //Prismite
            2465,                               //Mirage Fish
            2468,                               //Pixiefish
            2471,                               //Unicorn Fish
            3209,                               //Crystal Serpent
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:HallowFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Honey Fish", new int[]
            {
            2314,                               //Honeyfin
            2451,                               //Bumblebee Tuna
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:HoneyFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Jungle Fish", new int[]
            {
            2313,                               //Double Cod
            2302,                               //Neon Tetra
            2311,                               //Variegated Lardfish
            2452,                               //Catfish
            2483,                               //Derpfish
            2488,                               //Tropical Barracuda
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:JungleFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Magma Fish", new int[]
            {
            2312,                               //Flarefin Koi
            2315,                               //Obsidifish
            2331,                               //Obsidian Swordfish
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:MagmaFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Normal Fish", new int[]
            {
            261,                                //Goldfish
            2290,                               //Bass
            2301,                               //Red Snapper
            2298,                               //Salmon
            2297,                               //Trout
            2300,                               //Tuna
            2479,                               //Bunnyfish
            2480,                               //Cap'n Tunabeard
            2481,                               //Clownfish
            2459,                               //The Fish of Cthulhu
            3225,                               //Balloon Pufferfish
            2341,                               //Reaver Shark
            2342,                               //Sawtooth Shark
            2332,                               //Swordfish
            2481,                               //Reaver
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:NormalFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Sky Fish", new int[]
            {
            2304,                               //Damselfish
            2476,                               //Angelfish
            2453,                               //Cloudfish
            2458,                               //Fallen Starfish
            2461,                               //Harpyfish
            2473,                               //Wyverntail
            2420,                               //Zephyr Fish
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:SkyFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Snow Fish", new int[]
            {
            2299,                               //Atlantic Cod
            2306,                               //Frost Minnow
            2484,                               //Fishron
            2466,                               //Mutant Flinxfin
            2467,                               //Pengfish
            2470,                               //Tundra Trout
            3197,                               //Frost Daggerfish
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:SnowFish", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Underground Fish", new int[]
            {
            2303,                               //Armored Cavefish
            2309,                               //Specular Fish
            2321,                               //Stinkfish
            2475,                               //Amanitia Fungifin
            2450,                               //Batfish
            2482,                               //Demonic Hellfish
            2456,                               //Dynamite Fish
            2462,                               //Hungerfish
            2464,                               //Jewelfish
            2469,                               //Spiderfish
            2320,                               //Rockfish
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:UndergroundFish", g);

            //-------------------------------------Insect Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Gold Insect", new int[]
            {
            2891,                               //Gold Butterfly
            2893,                               //Gold Grasshopper
            2895,                               //Gold Worm
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:GoldInsect", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Hallow Insect", new int[]
            {
            2004,                               //Lightning Bug
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:HallowInsect", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Jungle Insect", new int[]
            {
            3194,                               //Buggy
            3192,                               //Grubby
            3193,                               //Sluggy
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:JungleInsect", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Normal Insect", new int[]
            {
            1992,                               //Firefly
            1994,                               //Monarch Butterfly
            1995,                               //Purple Emperor Butterfly
            1996,                               //Red Admiral Butterfly
            1997,                               //Ulysses Butterfly
            1998,                               //Sulphur Butterfly
            1999,                               //Tree Nymph Butterfly
            2000,                               //Zebra Swallowtail Butterfly
            2001,                               //Julia Butterfly
            2740,                               //Grasshopper
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:NormalInsect", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Underground Insect", new int[]
            {
            3191,                               //Enchanted Nightcrawler
            2673,                               //Truffle Worm
            2002,                               //Worm
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:UndergroundInsect", g);

            //-------------------------------------Mollusc Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Underground Mollusc", new int[]
            {
            2006,                               //Snail
            2007,                               //Glowing Snail
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:UndergroundMollusc", g);

            //-------------------------------------Rodent Meat-------------------------------------\\

            g = new RecipeGroup(() => Lang.misc[37] + " Gold Rodent", new int[]
            {
            3564,                               //Gold Squirrel
            2894,                               //Gold Mouse
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:GoldRodent", g);

            g = new RecipeGroup(() => Lang.misc[37] + " Normal Rodent", new int[]
            {
            3563,                               //Red Squirrel
            2018,                               //Squirrel
            });
            RecipeGroup.RegisterGroup("AdvancedTinkering:NormalRodent", g);
        }

        public override void AddRecipes()
        {
            //-------------------------------------Existing Recipes-------------------------------------\\

            RecipeFinder finder = new RecipeFinder();
            finder.SetResult(151);              //Necro Helmet
            foreach (Recipe r in finder.SearchRecipes())
            {
                RecipeEditor editor = new RecipeEditor(r);
                editor.DeleteTile(18);          //Workbench
                editor.AddTile(300);            //Bone Welder
            }

            finder = new RecipeFinder();
            finder.SetResult(152);              //Necro Breastplate
            foreach (Recipe r in finder.SearchRecipes())
            {
                RecipeEditor editor = new RecipeEditor(r);
                editor.DeleteTile(18);          //Workbench
                editor.AddTile(300);            //Bone Welder
            }

            finder = new RecipeFinder();
            finder.SetResult(153);              //Necro Greaves
            foreach (Recipe r in finder.SearchRecipes())
            {
                RecipeEditor editor = new RecipeEditor(r);
                editor.DeleteTile(18);          //Workbench
                editor.AddTile(300);            //Bone Welder
            }

            finder = new RecipeFinder();
            finder.AddIngredient(795);          //Blood Butcherer
            finder.AddIngredient(155);          //Muramasa
            finder.AddIngredient(190);          //Blade of Grass
            finder.AddIngredient(121);          //Fiery Greatsword
            finder.AddTile(26);                 //Altar
            finder.SetResult(273);              //Night's Edge
            Recipe exactRecipe = finder.FindExactRecipe();

            bool isRecipeFound = exactRecipe != null;
            if (isRecipeFound)
            {
                RecipeEditor editor = new RecipeEditor(exactRecipe);
                editor.DeleteRecipe();
            }

            //-------------------------------------New Recipes-------------------------------------\\

            /*
            recipe = new ModRecipe(this);
            recipe.AddIngredient(000);
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(000);
            recipe.AddRecipe();
            */

            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "TrueNightsEdgeB");
            recipe.AddIngredient(674);          //True Excalibur
            recipe.AddTile(134);                //Hardmode Anvil
            recipe.SetResult(757);              //Terra Blade
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "Obfuscator");
            recipe.AddIngredient(null, "CursedNaginata");
            recipe.AddIngredient(null, "BoOfGrass");
            recipe.AddIngredient(null, "HellHalberd");
            recipe.AddTile(26);                 //Altar
            recipe.SetResult(274);              //Dark Lance
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(706, 3);       //Platinum Bar
            recipe.AddIngredient(381, 12);      //Cobalt Bar
            recipe.AddIngredient(327);          //Golden Key
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(156);              //Cobalt Shield
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(147, 10);      //Spike
            recipe.AddIngredient(259, 6);       //Leather
            recipe.AddIngredient(225, 2);       //Silk
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(953);              //Climbing Claws
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(147, 10);      //Spike
            recipe.AddIngredient(259, 6);       //Leather
            recipe.AddIngredient(225, 2);       //Silk
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(975);              //Shoe Spikes
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(765, 90);      //Rain Cloud
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(19, 15);       //Gold Bar
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(158);              //Lucky Horseshoe
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(3756, 90);     //Snow Cloud
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(3306);         //White String
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(159);              //Shiny Red Balloon
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(751, 90);      //Cloud Block
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(31);           //Bottle
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(53);               //Cloud in a Bottle
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(169, 90);      //Sand Block
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(31);           //Bottle
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(857);              //Sandstorm in a Bottle
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(593, 90);      //Snow Block
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(31);           //Bottle
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(987);              //Blizzard in a Bottle
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(2435, 90);     //Coralstone Block
            recipe.AddIngredient(575, 5);       //Soul of Flight
            recipe.AddIngredient(31);           //Bottle
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(3201);             //Tsunami in a Bottle
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(318);          //Fireblossom
            recipe.AddIngredient(172, 100);     //Ash
            recipe.AddIngredient(173, 100);     //Obsidian
            recipe.AddIngredient(207, 3);       //Lava Bucket
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(1323);             //Obsidian Rose
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(275);          //Coral
            recipe.AddTile(18);                 //Workbench
            recipe.SetResult(2435);             //Coralstone Block
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(2435);         //Coralstone Block
            recipe.AddTile(18);                 //Workbench
            recipe.SetResult(275);              //Coral
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("AdvancedTinkering:AnimalSkin");
            recipe.AddTile(18);                 //Workbench
            recipe.SetResult(259, 12);          //Leather
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(225, 20);      //Silk
            recipe.AddIngredient(259, 20);      //Leather
            recipe.AddIngredient(254, 3);       //Black Thread
            recipe.AddTile(86);                 //Loom
            recipe.SetResult(410);              //Miner's Shirt
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(225, 15);      //Silk
            recipe.AddIngredient(259, 25);      //Leather
            recipe.AddIngredient(254, 3);       //Black Thread
            recipe.AddTile(86);                 //Loom
            recipe.SetResult(411);              //Miner's Pants
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(null, "RetinazerMask");
            recipe.AddIngredient(null, "SpazmatismMask");
            recipe.AddTile(18);                 //Workbench
            recipe.SetResult(2106);             //The Twins Mask
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(3111, 30);     //Pink Gel
            recipe.AddIngredient(23, 100);      //Gel
            recipe.AddIngredient(9, 7);         //Purity Wood
            recipe.AddTile(220);                //Solidifier
            recipe.SetResult(1309);             //Slime Staff
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(545, 999);     //Cursed Arrow
            recipe.AddIngredient(1334, 999);    //Ichor Arrow
            recipe.AddIngredient(47, 999);      //Unholy Arrow
            recipe.AddIngredient(516, 999);     //Holy Arrow
            recipe.AddIngredient(265, 999);     //Hellfire Arrow
            recipe.AddIngredient(3003, 999);    //Bone Arrow
            recipe.AddIngredient(259, 25);      //Leather
            recipe.AddTile(114);                //Tinkerer's Workshop
            recipe.SetResult(1321);             //Magic Quiver
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(210);          //Vine
            recipe.SetResult(2996, 6);          //Vine Rope
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("Wood", 3);
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(1922);             //Coal
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(2339);         //Tin Can
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(703);              //Tin Bar
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(766);          //Bone Block
            recipe.AddTile(300);                //Bone Welder
            recipe.SetResult(154);              //Bone
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(154, 5);       //Bone
            recipe.AddTile(300);                //Bone Welder
            recipe.SetResult(3003, 5);          //Bone Arrow
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(154);          //Bone
            recipe.AddIngredient(8, 3);         //Torch
            recipe.AddTile(300);                //Bone Welder
            recipe.SetResult(3004, 3);          //Bone Torch
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(19);           //Gold Bar
            recipe.SetResult(1348, 2);          //Gold Dust
            recipe.AddTile(247);                //Autohammer
            recipe.SetResult(327);              //Golden Key
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(1101, 8);      //Lihzahrd Brick
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(303);                //Lihzahrd Furnace
            recipe.SetResult(1142);             //Lihzahrd Chest
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(9, 8);         //Purity Wood
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(304);                //Living Loom
            recipe.SetResult(831);              //Living Wood Chest
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(824, 8);       //Sunplate Block
            recipe.AddRecipeGroup("IronBar", 2);
            recipe.AddTile(305);                //Sky Mill
            recipe.SetResult(838);              //Skyware Chest
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(3272);         //Hardened Sand Block
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(607, 2);           //Sandstone Brick
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(3271);         //Sandstone Block
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(607, 3);           //Sandstone Brick
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(586, 22);      //Candy Cane Block
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(1909);             //Candy Cane Sword
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(586, 24);      //Candy Cane Block
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(1917);             //Candy Cane Pickaxe
            recipe.AddRecipe();

            recipe = new ModRecipe(this);
            recipe.AddIngredient(586, 20);      //Candy Cane Block
            recipe.AddTile(17);                 //Furnace
            recipe.SetResult(1915);             //Candy Cane Hook
            recipe.AddRecipe();
        }
    }
}