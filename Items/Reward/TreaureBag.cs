using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Reward
{
    public class TreaureBag : GlobalItem
    {
        public override void OpenVanillaBag(string context, Player player, int arg)
        {
            if (arg == 3318)            //King Slime Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(1, 3));
            }
            if (arg == 3319)            //Eye of Cthulhu Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(3, 7));
            }
            if (arg == 3320)            //Eater of Worlds Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(7, 11));
            }
            if (arg == 3321)            //Brain of Cthulhu Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(7, 11));
            }
            if (arg == 3322)            //Queen Bee Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(9, 14));
            }
            if (arg == 3323)            //Skeletron Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(9, 14));
            }
            if (arg == 3324)            //Wall of Flesh Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(20, 25));
            }
            if (arg == 3325)            //Destroyer Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(25, 35));
            }
            if (arg == 3326)            //The Twins Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(30, 40));
            }
            if (arg == 3327)            //Skeletron Prime Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(28, 38));
            }
            if (arg == 3328)            //Plantera Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(40, 55));
            }
            if (arg == 3329)            //Golem Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(40, 45));
            }
            if (arg == 3330)            //Duke Fishron Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(50, 65));
            }
            if (arg == 3331)            //Lunatic Cultist Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(70, 85));
            }
            if (arg == 3332)            //Moon Lord Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(100, 120));
            }
            if (arg == 3862)            //Dark Mage Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(8, 13));
            }
            if (arg == 3861)            //Ogre Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(23, 31));
            }
            if (arg == 3860)            //Betsy Treasure Bag
            {
                player.QuickSpawnItem(mod.ItemType("RewardCredit"), Main.rand.Next(43, 53));
            }
        }
    }
}