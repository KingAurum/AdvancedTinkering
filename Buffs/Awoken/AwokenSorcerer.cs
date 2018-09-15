using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenSorcerer : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Sorcerer");
            Description.SetDefault("Allows the holder to automatically use mana potions when needed and restores mana from damage.\n" +
                "Increases magic damage by 30% and magic critical chance by 10%.\n" +
                "Increases maximum mana by 60 and reduces mana usage by 10%.\n" +
                "Increases pick up range for mana stars and boosts mana regeneration.\n" +
                "Grants Clairvoyance, Mana Regeneration, Magic Power and Star in a Bottle buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.manaFlower = true;
            player.magicCuffs = true;
            player.magicDamage += 0.55f;
            player.magicCrit += 12;
            player.statManaMax2 += 80;
            player.manaCost -= 0.10f;
            player.manaMagnet = true;
            player.manaRegenDelayBonus += 1;
            player.manaRegenBonus += 27;

            player.manaRegenBuff = true;    //Mana Regeneration
        }
	}
}
