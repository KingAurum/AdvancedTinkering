using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class CorruptionCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Corruption Cuisine");
            Description.SetDefault("'The strong smell makes it harder to eat'\n" +
                "Increases 15% ranged damage and 6% ranged critical chance.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.rangedDamage += 0.15f;
            player.rangedCrit += 6;
        }
    }
}
