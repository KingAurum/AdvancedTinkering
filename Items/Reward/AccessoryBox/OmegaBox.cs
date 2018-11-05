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
    public class OmegaBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Omega Box");
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
            item.createTile = mod.TileType("OmegaBoxTile");
            item.maxStack = 99;
            item.width = 48;
            item.height = 32;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 9;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(10);

                if (choice == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("OldArmorScroll"));
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(mod.ItemType("OldWeaponScroll"));
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(mod.ItemType("Antivenom"));
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(mod.ItemType("SpiderScissors"));
                }
                else if (choice == 4)
                {
                    player.QuickSpawnItem(mod.ItemType("CursedWater"));
                }
                else if (choice == 5)
                {
                    player.QuickSpawnItem(mod.ItemType("IchorWater"));
                }
                else if (choice == 6)
                {
                    player.QuickSpawnItem(mod.ItemType("ShadowWater"));
                }
                else if (choice == 7)
                {
                    player.QuickSpawnItem(mod.ItemType("FrostWater"));
                }
                else if (choice == 8)
                {
                    player.QuickSpawnItem(mod.ItemType("EyeDrops"));
                }
                else if (choice == 9)
                {
                    player.QuickSpawnItem(mod.ItemType("TissueBox"));
                }
            }
            else if (Main.rand.NextFloat() < 0.90f)
            {
                int choice = Main.rand.Next(5);

                if (choice == 0)
                {
                    player.QuickSpawnItem(mod.ItemType("OldProtectionScroll"));
                }
                else if (choice == 1)
                {
                    player.QuickSpawnItem(mod.ItemType("ArachnoKiller"));
                }
                else if (choice == 2)
                {
                    player.QuickSpawnItem(mod.ItemType("CursedIchorWater"));
                }
                else if (choice == 3)
                {
                    player.QuickSpawnItem(mod.ItemType("ShadowFrostWater"));
                }
                else if (choice == 4)
                {
                    player.QuickSpawnItem(mod.ItemType("Ointment"));
                }
            }
            else
            {
                player.QuickSpawnItem(mod.ItemType("OmegaCharm"));
            }
        }
    }


    public class OmegaBoxTile : ModTile
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
            
            AddMapEntry(new Color(3, 156, 200));

            dustType = 1;
            disableSmartCursor = true;

            adjTiles = new int[]
            {
            };

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("OmegaBoxItem"));
        }
    }
}