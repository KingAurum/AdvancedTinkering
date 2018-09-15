using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenHealing : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Healing");
            Description.SetDefault("Increases maximum life by 50.\n" +
                "Allows the holder a continuous life regeneration that greatly increases when not moving.\n" +
                "Reduce healing items cooldown.\n" +
                "Grants Cozy Fire, Heart Lamp, Honey, Lifeforce, Rapid Healing and Regeneration buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.statLifeMax2 += 50;
            player.lifeRegenTime += 2;
            player.lifeRegen += 17;
            player.shinyStone = true;
            player.pStone = true;

            player.lifeForce = true;
            player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20;
        }
	}
}
