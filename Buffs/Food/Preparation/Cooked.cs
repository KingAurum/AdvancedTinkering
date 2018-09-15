using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Preparation
{
	public class Cooked : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cooked");
            Description.SetDefault("'Sometimes the simple is better.'\n" +
                "Minor increases to regeneration, defense and movement speed.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegen += 2;
            player.statDefense += 3;
            player.moveSpeed += 0.6f;
        }
    }
}
