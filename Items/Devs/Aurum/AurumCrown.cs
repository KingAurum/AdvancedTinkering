using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Aurum
{
    [AutoloadEquip(EquipType.Head)]
    public class AurumCrown : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aurum Crown");
            Tooltip.SetDefault("'Great for impersonating modders!'");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 24;
            item.value = Item.sellPrice(0, 3, 0, 0);
            item.rare = 9;
            item.vanity = true;
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("AurumBreastplate") && legs.type == mod.ItemType("AurumGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Become the Golden King Aurum!";
        }
	}
}