using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{ 
	public class AwokenRanger : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Ranger");
            Description.SetDefault("Allows the holder to zoom with ranged weapons using right click.\n" +
                "Increases ranged damage by 25%, and ranged critical strike chance by 10%.\n" +
                "Increases to 35% arrow damage.\n" +
                "20% chance of not consuming arrows.\n" +
                "Grants Ammo Box, Ammo Reservation and Archery buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.scope = true;
            player.rangedDamage += 0.25f;
            player.rangedCrit += 10;
            player.arrowDamage += 0.35f;
            player.magicQuiver = true;

            player.archery = true;      //Archery
            player.ammoBox = true;      //Ammo Box
            player.ammoPotion = true;   //Ammo Reservation
        }
	}
}
