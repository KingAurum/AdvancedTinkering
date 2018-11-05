using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Vanity.Others
{
    [AutoloadEquip(EquipType.Head)]
    public class DiseasterBunnyHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diseaster Bunny Hood");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 26;
            item.value = Item.sellPrice(0, 0, 40, 0);
            item.rare = 0;
            item.vanity = true;
        }
	}
}