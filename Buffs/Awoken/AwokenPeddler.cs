using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenPeddler : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Peddler");
            Description.SetDefault("Allows the holder an increased range to pick up mana stars and coins.\n" +
                "Hitting enemies will sometimes drop extra coins and shops have lower prices.\n" +
                "Allows the holder to dash, run incredibly fast, walk on liquids and climb walls.\n" +
                "10 seconds of lava immunity and immunity to fire blocks.\n" +
                "Extra mobility on ice and air.\n" +
                "Grants Heartreach, Dangersense, Hunter and Swiftness buffs.");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.manaMagnet = true;
            player.goldRing = true;
            player.coins = true;
            player.discount = true;

            player.lifeMagnet = true;       //Heartreach


            player.dash = 1;
            player.accRunSpeed = 6.75f;
            player.waterWalk2 = true;
            player.spikedBoots = 2;
            player.rocketBoots = 3;
            player.socialShadowRocketBoots = true;
            player.moveSpeed += 1.45f;
            player.lavaMax += 600;
            player.fireWalk = true;
            player.iceSkate = true;

            player.detectCreature = true;   //Hunter
            player.dangerSense = true;      //Dangersense
        }
    }
}
