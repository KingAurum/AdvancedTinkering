using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenSummoner : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Summoner");
            Description.SetDefault("Allows the holder to summon +5 minions and +8 sentries.\n" +
                "Increases the minion damage by 78% and knockback by 30%.\n" +
                "Increases defense by 3, movement speed by 5% and maximum mana by 20.\n" +
                "Grants Bewitched and Summoning buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.maxMinions += 7;
            player.maxTurrets += 8;
            player.minionDamage += 0.78f;
            player.minionKB += 0.30f;
            player.statDefense += 3;
            player.moveSpeed += 0.05f;
            player.statManaMax2 += 20;
        }
    }
}
