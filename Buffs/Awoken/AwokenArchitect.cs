using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenArchitect : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Architect");
            Description.SetDefault("Increases tile and wall placement speed and reach by 11 blocks.\n" +
                "Automatically paints and put actuators on placed objects.\n" +
                "36% increased mining speed.\n" +
                "Grants Builder, Spelunker, Shine, Night Owl and Mining buffs");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            if (player.whoAmI == Main.myPlayer)
            {
                Player.tileRangeX += 11;
                Player.tileRangeY += 11;
            }
            player.wallSpeed += 0.11f;
            player.tileSpeed += 0.11f;
            player.autoPaint = true;
            player.autoActuator = true;


            player.pickSpeed -= 0.75f;

            player.findTreasure = true;     //Spelunker
            Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.8f, 0.95f, 1f);  //Shine
            player.nightVision = true;      //Night Owl
        }
    }
}
