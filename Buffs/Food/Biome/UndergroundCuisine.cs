using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class UndergroundCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Underground Cuisine");
            Description.SetDefault("'A little too heavy for me.'\n" +
                "Increases 4 defense and 6% endurance, but sightly decreases movement speed.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 4;
            player.endurance += 0.06f;
            player.moveSpeed -= 0.03f;
        }
    }
}
