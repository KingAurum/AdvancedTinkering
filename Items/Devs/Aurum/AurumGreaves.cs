using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Aurum
{
    [AutoloadEquip(EquipType.Legs)]
    public class AurumGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aurum Greaves");
            Tooltip.SetDefault("'Great for impersonating modders!'");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 9;
            item.vanity = true;
        }

        public override void UpdateEquip(Player player)
        {
        }
    }
}