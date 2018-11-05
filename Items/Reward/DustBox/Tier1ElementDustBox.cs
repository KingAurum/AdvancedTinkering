using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ObjectData;

namespace AdvancedTinkering.Items.Reward.DustBox
{
    public class Tier1ElementDustBoxItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tier 1 Element Dust Box");
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
            item.createTile = mod.TileType("Tier1ElementDustBoxTile");
            item.maxStack = 99;
            item.width = 48;
            item.height = 32;
            item.value = Item.sellPrice(0, 0, 1, 25);
            item.rare = 1;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void RightClick(Player player)
        {
            if (Main.rand.NextFloat() < 0.75f)
            {
                player.QuickSpawnItem(mod.ItemType("CarbonDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.75f)
            {
                player.QuickSpawnItem(mod.ItemType("SiliconDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.75f)
            {
                player.QuickSpawnItem(mod.ItemType("SulfurDust"), Main.rand.Next(24, 60));
            }

            if (Main.rand.NextFloat() < 0.70f)
            {
                player.QuickSpawnItem(mod.ItemType("CopperDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.70f)
            {
                player.QuickSpawnItem(mod.ItemType("TinDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.70f)
            {
                player.QuickSpawnItem(mod.ItemType("ZincDust"), Main.rand.Next(24, 60));
            }

            if (Main.rand.NextFloat() < 0.65f)
            {
                player.QuickSpawnItem(mod.ItemType("IronDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.65f)
            {
                player.QuickSpawnItem(mod.ItemType("LeadDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.65f)
            {
                player.QuickSpawnItem(mod.ItemType("AluminiumDust"), Main.rand.Next(24, 60));
            }

            if (Main.rand.NextFloat() < 0.60f)
            {
                player.QuickSpawnItem(mod.ItemType("MagnesiumDust"), Main.rand.Next(24, 60));
            }

            if (Main.rand.NextFloat() < 0.55f)
            {
                player.QuickSpawnItem(mod.ItemType("SilverDust"), Main.rand.Next(24, 60));
            }
            if (Main.rand.NextFloat() < 0.55f)
            {
                player.QuickSpawnItem(mod.ItemType("TungstenDust"), Main.rand.Next(24, 60));
            }

            if (Main.rand.NextFloat() < 0.50f)
            {
                player.QuickSpawnItem(mod.ItemType("ChromiumDust"), Main.rand.Next(15, 45));
            }
            if (Main.rand.NextFloat() < 0.50f)
            {
                player.QuickSpawnItem(mod.ItemType("ManganeseDust"), Main.rand.Next(15, 45));
            }

            if (Main.rand.NextFloat() < 0.45f)
            {
                player.QuickSpawnItem(mod.ItemType("NickelDust"), Main.rand.Next(15, 45));
            }

            if (Main.rand.NextFloat() < 0.40f)
            {
                player.QuickSpawnItem(mod.ItemType("GoldDust"), Main.rand.Next(15, 45));
            }
            if (Main.rand.NextFloat() < 0.40f)
            {
                player.QuickSpawnItem(mod.ItemType("PlatinumDust"), Main.rand.Next(15, 45));
            }
        }
    }


    public class Tier1ElementDustBoxTile : ModTile
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
            
            AddMapEntry(new Color(95, 98, 158));

            dustType = 1;
            disableSmartCursor = true;

            adjTiles = new int[]
            {
            };

            TileObjectData.addTile(Type);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 48, mod.ItemType("Tier1ElementDustBoxItem"));
        }
    }
}