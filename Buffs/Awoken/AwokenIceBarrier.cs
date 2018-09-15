using Terraria;
using Terraria.ModLoader;

using AdvancedTinkering;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenIceBarrier : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Ice Barrier");
            Description.SetDefault("000.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.endurance += 0.30f;
        }
	}
}
