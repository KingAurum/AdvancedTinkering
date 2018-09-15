using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenWarrior : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Warrior");
            Description.SetDefault("Allows the holder to inflict fire with melee attacks.\n" +
                "Increases 30% melee damage, 15% melee speed and 80% melee knockback.\n" +
                "Increases yoyos range by 5 blocks, allows using two yoyos and counterweights at once.\n" +
                "Grants Sharpened buff.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.magmaStone = true;
            player.meleeDamage += 0.30f;
            player.meleeSpeed += 0.15f;
            player.kbGlove = true;
            player.counterWeight = 556 + Main.rand.Next(6);
            player.yoyoGlove = true;
            player.yoyoString = true;

            if (player.inventory[player.selectedItem].melee)
            {
                player.armorPenetration = 4;
            }
        }
	}
}
