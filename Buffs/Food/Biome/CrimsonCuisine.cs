using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Food.Biome
{
	public class CrimsonCuisine : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Crimson Cuisine");
            Description.SetDefault("'Who would think that it would be edible?'\n" +
                "Increases 15% melee damage and 6% melee critical chance.");
            Main.debuff[Type] = true;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.15f;
            player.meleeCrit += 6;
        }
    }
}
