using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace AdvancedTinkering.Items.Reward.AccessoryBox
{
    public class CellPhonePartsBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cell Phone Parts Box");
            Tooltip.SetDefault("<right> to open the box.");
        }

        public override void SetDefaults()
        {
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("CellPhonePartsBoxTile");
            item.maxStack = 99;
            item.width = 48;
            item.height = 32;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 5;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(12);

                if (choice == 0)
                {
                    player.QuickSpawnItem(3120);        //Fisherman's Pocket Guide
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(3037);        //Weather Radio
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(3096);        //Sextant
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(3119);        //DPS Meter
                }
                else if (choice == 4)
                {
                    player.QuickSpawnItem(3099);         //Stopwatch
                }
                else if (choice == 5)
                {
                    player.QuickSpawnItem(3102);         //Metal Detector
                }
                else if (choice == 6)
                {
                    player.QuickSpawnItem(393);         //Compass
                }
                else if (choice == 7)
                {
                    player.QuickSpawnItem(18);          //Depth Meter
                }
                else if (choice == 8)
                {
                    player.QuickSpawnItem(17);          //Gold Watch
                }
                else if (choice == 9)
                {
                    player.QuickSpawnItem(3118);        //Lifeform Analyzer
                }
                else if (choice == 10)
                {
                    player.QuickSpawnItem(3084);        //Radar
                }
                else if (choice == 11)
                {
                    player.QuickSpawnItem(3095);        //Tally Counter
                }
            }
            else if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(4);

                if (choice == 0)
                {
                    player.QuickSpawnItem(3036);        //Fish Finder
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(3121);        //Goblin Tech
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(395);         //GPS
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(3122);        //R.E.K. 3000
                }
            }
            else
            {
                player.QuickSpawnItem(3123);            //PDA
            }
        }
    }


    public class CellPhonePartsBoxTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileBlockLight[Type] = false;
            Main.tileSolid[Type] = false;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;

            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.Origin = new Point16(1, 1);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.LavaDeath = true;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16, 16, 16 };
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;

            animationFrameHeight = 36;
            
            AddMapEntry(new Color(209, 124, 208));

            dustType = 1;
            disableSmartCursor = true;

            adjTiles = new int[]
            {
            };

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("CellPhonePartsBoxItem"));
        }
    }
}