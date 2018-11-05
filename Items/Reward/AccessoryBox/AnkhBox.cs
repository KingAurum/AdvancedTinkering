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
    public class AnkhBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ankh Box");
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
            item.createTile = mod.TileType("AnkhBoxTile");
            item.maxStack = 99;
            item.width = 48;
            item.height = 32;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 7;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(9);

                if (choice == 0)
                {
                    player.QuickSpawnItem(886);         //Armor Polish
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(892);         //Vitamins
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(887);         //Bezoar
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(885);         //Adhesive Bandage
                }
                else if (choice == 4)
                {
                    player.QuickSpawnItem(889);         //Fast Clock
                }
                else if (choice == 5)
                {
                    player.QuickSpawnItem(893);         //Trifold Map
                }
                else if (choice == 6)
                {
                    player.QuickSpawnItem(890);         //Megaphone
                }
                else if (choice == 7)
                {
                    player.QuickSpawnItem(891);         //Nazar
                }
                else if (choice == 8)
                {
                    player.QuickSpawnItem(888);         //Blindfold
                }
            }
            else if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(4);

                if (choice == 0)
                {
                    player.QuickSpawnItem(901);         //Armor Bracing
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(902);         //Medicated Bandage
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(903);         //The Plan
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(904);         //Countercurse Mantra
                }
            }
            else
            {
                player.QuickSpawnItem(1612);            //Ankh Charm
            }
        }
    }


    public class AnkhBoxTile : ModTile
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
            
            AddMapEntry(new Color(115, 195, 7));

            dustType = 1;
            disableSmartCursor = true;

            adjTiles = new int[]
            {
            };

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("AnkhBoxItem"));
        }
    }
}