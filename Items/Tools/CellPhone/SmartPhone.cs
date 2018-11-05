using Microsoft.Xna.Framework;
using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace AdvancedTinkering.Items.Tools.CellPhone
{
    public class SmartPhone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Smart Phone");
            Tooltip.SetDefault("Multiple toggleable apps!\n" +
                "Return to Spawn app!");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = Item.sellPrice(0, 9, 0, 0); ;
            item.rare = 7;
            item.useTurn = true;
            item.useStyle = 4;
            item.useTime = 15;
            item.useAnimation = 15;
            item.UseSound = SoundID.Item6;
        }

        public override void UpdateInventory(Player player)
        {
            player.accWatch = 3;
            player.accDepthMeter = 1;
            player.accCompass = 1;

            player.accFishFinder = true;
            player.accWeatherRadio = true;
            player.accCalendar = true;

            player.accThirdEye = true;
            player.accJarOfSouls = true;
            player.accCritterGuide = true;

            player.accStopwatch = true;
            player.accOreFinder = true;
            player.accDreamCatcher = true;

            player.autoActuator = true;
            player.InfoAccMechShowWires = true;
            player.rulerGrid = true;
            player.rulerLine = true;
            player.autoPaint = true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 4;
                item.useTime = 21;
                item.useAnimation = 24;
                item.UseSound = SoundID.Item6;
            }
            else
            {
                item.useTurn = true;
                item.useStyle = 4;
                item.useTime = 15;
                item.useAnimation = 18;
                item.UseSound = SoundID.Item6;
            }
            return base.CanUseItem(player);
        }

        public override void UseStyle(Player player)
        {
            if (player.altFunctionUse == 2)
            {

            }
            else
            {
                if (Main.rand.NextBool(2))
                {
                    Dust.NewDust(player.position, player.width, player.height, 10, 0f, 0f, 150, default(Color), 1.1f);
                }

                if (player.itemTime == 0)
                {
                    player.itemTime = (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item));
                }

                else if (player.itemTime == (int)(item.useTime / PlayerHooks.TotalUseTimeMultiplier(player, item)) / 2)
                {
                    for (int d = 0; d < 45; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 10, player.velocity.X * 0.5f, player.velocity.Y * 0.5f, 150, default(Color), 1.5f);
                    }

                    player.grappling[0] = -1;
                    player.grapCount = 0;

                    for (int p = 0; p < 1000; p++)
                    {
                        if (Main.projectile[p].active && Main.projectile[p].owner == player.whoAmI && Main.projectile[p].aiStyle == 7)
                        {
                            Main.projectile[p].Kill();
                        }
                    }

                    player.Spawn();

                    for (int d = 0; d < 45; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 10, 0f, 0f, 150, default(Color), 1.5f);
                    }
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3124);         //Cell Phone
            recipe.AddIngredient(3624);         //Presserator
            recipe.AddIngredient(3619);         //Mechanical Lens
            recipe.AddIngredient(2799);         //Mechanical Ruler
            recipe.AddIngredient(486);          //Ruler
            recipe.AddIngredient(2216);         //Paint Sprayer
            recipe.AddIngredient(2350, 30);     //Recall Potion
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}