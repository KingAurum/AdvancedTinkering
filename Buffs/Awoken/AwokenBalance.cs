using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenBalance : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Balance");
            Description.SetDefault("Allows the holder to absorb 25% of damage done to teammates while above 25% health.\n" +
                "Gives a chance to dodge attacks, reduces lava damage, 17% of all damage and 32% while under 50% health.\n" +
                "When damaged, increases the holder speed, length of invincibility and releases hallow stars and bees.\n" +
                "Allows the holder to do attacks that can ignore target defense.\n" +
                "25% increased damage and critical strike chance.\n" +
                "When damaged has a chance to confuse nearby enemies.\n" +
                "Increases the strength of friendly bees.\n" +
                "Summons spores over time that will damage enemies.\n" +
                "Gives Ironskin, Thorns, Endurance, Warmth, Titan, Rage and Wrath buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            //add_Paladin_Shield_effect_here
            player.blackBelt = true;
            player.lavaRose = true;
            player.endurance += 0.17f;
            if (player.statLife <= player.statLifeMax2 * 0.5)
            {
                player.iceBarrier = true;
                player.endurance += 0.25f;
            }
            player.GetModPlayer<ATPlayer>(mod).AwokenPanic = true;
            player.panic = true;
            player.longInvince = true;
            player.starCloak = true;
            player.bee = true;

            player.statDefense += 8;        //Ironskin
            player.thorns = 0.3333333f;     //Thorns
            player.endurance += 0.1f;       //Endurance
            player.resistCold = true;       //Warmth
            

            player.armorPenetration += 5;
            player.meleeDamage += 0.25f;
            player.meleeCrit += 25;
            player.rangedDamage += 0.25f;
            player.rangedCrit += 25;
            player.magicDamage += 0.25f;
            player.magicCrit += 25;
            player.minionDamage += 0.25f;
            player.thrownDamage += 0.25f;
            player.thrownCrit += 25;
            player.brainOfConfusion = true;
            player.strongBees = true;
            player.SporeSac();
            player.sporeSac = true;

            player.kbBuff = true;   //Titan
        }
    }
}
