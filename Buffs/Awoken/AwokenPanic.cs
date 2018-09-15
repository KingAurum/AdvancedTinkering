using Terraria;
using Terraria.ModLoader;

using AdvancedTinkering;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenPanic : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Panic!");
            Description.SetDefault("Movement speed is increased.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.moveSpeed += 1.5f;
        }
	}
}
