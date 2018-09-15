using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenAngry : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Angry");
            Description.SetDefault("Grants Battle and Water Candle buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.aggro += 1400;

            player.buffImmune[mod.BuffType("AwokenCalm")] = true;      //Awoken Calm

            player.enemySpawns = true;      //Battle
            player.ZoneWaterCandle = true;  //Water Candle
        }
	}
}
