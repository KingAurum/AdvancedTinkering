using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class JungleCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Jungle Cuisine");
            Description.SetDefault("'Those Lihzahrds surely can make a good dish.'\n" +
                "Increases 15% summon damage.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.minionDamage += 0.15f;
        }
    }
}
