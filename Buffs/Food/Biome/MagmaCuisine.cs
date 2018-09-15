using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class MagmaCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Magma Cuisine");
            Description.SetDefault("'From the depths of the underworld to my belly!'\n" +
                "Protects from Chilled, Frozen and reduces cold damage.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.buffImmune[46] = true;   //Chilled
            player.buffImmune[47] = true;   //Frozen
            player.resistCold = true;       //Warmth
        }
    }
}
