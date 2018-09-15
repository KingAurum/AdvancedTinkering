using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class HoneyCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Honey Cuisine");
            Description.SetDefault("'The Angler likes honey, so maybe I should offer him a bit next time. Nah.'\n" +
                "Increases life regeneration.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.lifeRegenTime += 1;
            player.lifeRegen += 2;
        }
    }
}
