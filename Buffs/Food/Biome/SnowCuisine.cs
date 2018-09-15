using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class SnowCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Snow Cuisine");
            Description.SetDefault("'Better served cold.'\n" +
                "Protects from On Fire!, Burning and reduces lava damage.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.buffImmune[24] = true;   //On Fire!
            player.buffImmune[67] = true;   //Burning
            player.lavaRose = true;         //Obsidian Rose
        }
    }
}
