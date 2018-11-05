using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Aurum
{
	[AutoloadEquip(EquipType.Front)]
	public class AurumCape : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Aurum Cape");
            Tooltip.SetDefault("'Great for impersonating modders!'");
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 34;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 9;
			item.accessory = true;
		}
        
        public override void UpdateAccessory(Player player, bool hideVisual)
        {

        }
    }
}