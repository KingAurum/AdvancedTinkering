using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class NormalCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Normal Cuisine");
            Description.SetDefault("'Good old normal food.'\n" +
                "Increases 10% mining speed and tile reach by 2.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.10f;
            if (player.whoAmI == Main.myPlayer)
            {
                Player.tileRangeX += 2;
                Player.tileRangeY += 2;
            }
        }
    }
}
