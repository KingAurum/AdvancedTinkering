using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Matt0x
{
    [AutoloadEquip(EquipType.Body)]
    public class Matt0xJacket : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Matt0x's Jacket");
            Tooltip.SetDefault("'Great for impersonating modders!'");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 9;
            item.vanity = true;
        }
    }
}