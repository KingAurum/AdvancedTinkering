using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Preparation
{
	public class FishSticks : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Fish Sticks");
            Description.SetDefault("'For when you need to explore the ocean.'\n" +
                "Increases mobility in water.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.ignoreWater = true;
            player.accFlipper = true;
            player.accDivingHelm = true;
        }
    }
}
