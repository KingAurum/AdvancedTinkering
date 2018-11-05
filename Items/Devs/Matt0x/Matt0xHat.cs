using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Devs.Matt0x
{
    [AutoloadEquip(EquipType.Head)]
    public class Matt0xHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Matt0x's Hat");
            Tooltip.SetDefault("'Great for impersonating modders!'");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 24;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 9;
            item.vanity = true;
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("Matt0xJacket") && legs.type == mod.ItemType("Matt0xPants");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Be more colorful!";
        }
	}
}