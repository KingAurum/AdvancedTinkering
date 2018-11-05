using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Waters
{
	public class GoldenWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot("GoldenBiomeSurfaceBG");
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot("GoldenWaterfallStyle");
		}

		public override int GetSplashDust()
		{
			return mod.DustType("GoldenWaterSplash");
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot("Gores/GoldenDroplet");
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.Yellow;
		}
	}
}