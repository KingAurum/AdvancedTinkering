using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenAntiDebuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Anti-Debuff");
            Description.SetDefault("Grants immunity to Knockback, Lava and 35 Debuffs:\n" +
                "Bleeding, Broken Armor, Blackout, Burning, Celled, Chilled, \n" +
                "Confused, Cursed, Cursed Inferno, Darkness, Daybroken, Distorted, \n" +
                "Electrified, Frostburn, Frozen, Horrified, Ichor, Mighty Wind, \n" +
                "Moon Bite, Obstructed, On Fire!, Oozed, Penetrated, Poisoned, \n" +
                "Shadowflame, Silenced, Slow, Stoned, Suffocation, The Tongue, \n" +
                "Venom, Weak, Webbed, Withered Armor, Withered Weapon.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.noKnockback = true;
            player.lavaImmune = true;

            player.buffImmune[20] = true;   //Poisoned
            player.buffImmune[22] = true;   //Darkness
            player.buffImmune[23] = true;   //Cursed
            player.buffImmune[24] = true;   //On Fire!
            player.buffImmune[30] = true;   //Bleeding
            player.buffImmune[31] = true;   //Confused
            player.buffImmune[32] = true;   //Slow
            player.buffImmune[33] = true;   //Weak
            player.buffImmune[35] = true;   //Silenced
            player.buffImmune[36] = true;   //Broken Armor
            player.buffImmune[37] = true;   //Horrified
            player.buffImmune[38] = true;   //The Tongue
            player.buffImmune[39] = true;   //Cursed Inferno
            player.buffImmune[44] = true;   //Frostburn
            player.buffImmune[46] = true;   //Chilled
            player.buffImmune[47] = true;   //Frozen
            player.buffImmune[67] = true;   //Burning
            player.buffImmune[68] = true;   //Suffocation
            player.buffImmune[69] = true;   //Ichor
            player.buffImmune[70] = true;   //Venom
            player.buffImmune[80] = true;   //Blackout
            player.buffImmune[144] = true;  //Electrified
            player.buffImmune[145] = true;  //Moon Bite
            player.buffImmune[149] = true;  //Webbed
            player.buffImmune[153] = true;  //Shadowflame
            player.buffImmune[156] = true;  //Stoned
            player.buffImmune[163] = true;  //Obstructed
            player.buffImmune[164] = true;  //Distorted
            player.buffImmune[169] = true;  //Penetrated
            player.buffImmune[183] = true;  //Celled
            player.buffImmune[189] = true;  //Daybroken
            player.buffImmune[194] = true;  //Mighty Wind
            player.buffImmune[195] = true;  //Withered Armor
            player.buffImmune[196] = true;  //Withered Weapon
            player.buffImmune[197] = true;  //Oozed
        }
    }
}