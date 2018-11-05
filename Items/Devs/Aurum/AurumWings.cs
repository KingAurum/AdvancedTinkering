using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Aurum
{
    [AutoloadEquip(EquipType.Wings)]
    public class AurumWings : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Aurum Wings");
            Tooltip.SetDefault("Allows flight and slow fall.\n" +
                "'Great for impersonating modders!'");
        }

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 28;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 9;
			item.accessory = true;
		}
        
        public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 180;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 3f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 9f;
            acceleration *= 2.5f;
        }
    }
}