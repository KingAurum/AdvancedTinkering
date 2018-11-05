using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Currency
{
    public class RewardCredit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reward Credit");
            Tooltip.SetDefault("Used to buy rewards");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = Item.buyPrice(0, 0, 1, 0);
            item.rare = 1;
            item.maxStack = 999;
        }
    }
}