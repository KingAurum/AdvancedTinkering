using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class DesertCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Desert Cuisine");
            Description.SetDefault("'Wasn't it supposed to be eaten without the sand?'\n" +
                "Increases 15% throwning damage and 6% throwning critical chance.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.thrownDamage += 0.15f;
            player.thrownCrit += 6;
        }
    }
}
