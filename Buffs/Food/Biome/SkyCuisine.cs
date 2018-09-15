using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class SkyCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Sky Cuisine");
            Description.SetDefault("'Makes me feel lighter.'\n" +
                "Increases 12% movement speed and makes you lighter.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.12f;
            player.slowFall = true;     //Featherfall
        }
    }
}
