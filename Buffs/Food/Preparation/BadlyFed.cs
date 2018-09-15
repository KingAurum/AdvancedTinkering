using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Preparation
{
	public class BadlyFed : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Badly Fed");
            Description.SetDefault("Minor diminishments to all stats.\n" +
                "Negates life regeneration.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegenTime = 0;
            player.moveSpeed -= 0.20f;
            player.statDefense -= 2;

            player.meleeDamage -= 0.05f;
            player.meleeCrit -= 2;
            player.meleeSpeed -= 0.05f;
            player.rangedDamage -= 0.05f;
            player.rangedCrit -= 2;
            player.magicDamage -= 0.05f;
            player.magicCrit -= 2;
            player.minionDamage -= 0.05f;
            player.minionKB -= 0.50f;
            player.thrownDamage -= 0.05f;
            player.thrownCrit -= 2;

            player.buffImmune[26] = true;    //Well Fed
        }
    }
}
