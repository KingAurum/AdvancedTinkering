using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class HallowCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Hallow Cuisine");
            Description.SetDefault("'I will probably burp glitter for days.'\n" +
                "Increases 15% magic damage and 6% magic critical chance.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.magicDamage += 0.15f;
            player.magicCrit += 6;
        }
    }
}
