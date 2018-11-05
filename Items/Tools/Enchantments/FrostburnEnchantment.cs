using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AdvancedTinkering;

namespace AdvancedTinkering.Items.Tools.Enchantments
{
    public class FrostburnEnchantment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frostburn Enchantment");
            Tooltip.SetDefault("Magic attacks inflict enemies with Frostburn.");
        }

        public override void SetDefaults()
        {
            item.mana = 220;
            item.noMelee = true;
            item.useTurn = true;
            item.useAnimation = 300;
            item.useTime = 180;
            item.useStyle = 4;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/LunaticCultist1");
            item.width = 30;
            item.height = 30;
            item.value = Item.sellPrice(0, 2, 75, 0);
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "PaperItem");
            recipe.AddIngredient(2161, 6);      //Frost Core
            recipe.AddTile(233);                //Imbuing Station
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("FrostburnEnchantment"), 86400);
            return true;
        }

        public override void HoldItem(Player player)
        {
            player.manaCost = 220;
        }
    }
}