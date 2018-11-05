using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace AdvancedTinkering.Items.Reward.ChestBox
{
    public class HallowedMimicBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Mimic Box");
            Tooltip.SetDefault("<right> to open the box.\n" +
                "Requires a Key of Light.");
        }

        public override void SetDefaults()
        {
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("HallowedMimicBoxTile");
            item.maxStack = 99;
            item.width = 48;
            item.height = 32;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 5;
        }

        public override bool CanRightClick()
        {
            if (Main.player[Main.myPlayer].HasItem(3092))               //Key of Light
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void RightClick(Player player)
        {
            player.inventory[player.FindItem(3092)].stack -= 1; //Key of Light

            int choice = Main.rand.Next(4);

            if (choice == 0)
            {
                player.QuickSpawnItem(3030);        //Flying Knife
            }
            else if (choice == 1)
            {
                player.QuickSpawnItem(3029);        //Daedalus Stormbow
            }
            else if (choice == 2)
            {
                player.QuickSpawnItem(3051);        //Crystal Vile Shard
            }
            else if (choice == 3)
            {
                player.QuickSpawnItem(3022);        //Illuminant Hook
            }
        }
    }


    public class HallowedMimicBoxTile : ModTile
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
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("HallowedMimicBoxItem"));
        }
    }
}