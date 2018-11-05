using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Vanity.BossMask
{
    [AutoloadEquip(EquipType.Head)]
    public class SantaNK1Mask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Santa-NK1 Mask");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 32;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 1;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
        }
    }
}