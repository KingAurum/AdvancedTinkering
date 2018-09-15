using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenAirAndWater : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Air and Water");
            Description.SetDefault("Allows the holder to do an faster, higher, automatic and sextuple jump.\n" +
                "Negates fire blocks and fall damage.\n" +
                "Releases bees when damaged.\n" +
                "Allows the holder the ability to swim and light under water.\n" +
                "Greatly extends underwater breathing and mobility on ice and water.\n" +
                "Fishing line will never break, decreases the chance of bait consumption and increases fishing skill.\n" +
                "Gives Crate, Featherfall, Fishing, Flipper, Gills, Gravitation and Sonar buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.doubleJumpSandstorm = true;
            player.doubleJumpBlizzard = true;
            player.doubleJumpFart = true;
            player.doubleJumpSail = true;
            player.doubleJumpCloud = true;
            player.jumpBoost = true;
            player.autoJump = true;
            player.jumpSpeedBoost += 2.4f;
            player.fireWalk = true;
            player.noFallDmg = true;
            player.bee = true;

            player.slowFall = true;     //Featherfall
            player.gravControl = true;  //Gravitation


            player.arcticDivingGear = true;
            player.accFlipper = true;
            player.accDivingHelm = true;
            player.iceSkate = true;
            player.ignoreWater = true;  //Flipper
            if (player.wet)
            {
                Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.8f, 0.95f, 1f);
            }
            player.accFishingLine = true;
            player.accTackleBox = true;
            player.fishingSkill += 30;

            player.gills = true;        //Gills
            player.sonarPotion = true;  //Sonar
            player.cratePotion = true;  //Crate
        }
    }
}
