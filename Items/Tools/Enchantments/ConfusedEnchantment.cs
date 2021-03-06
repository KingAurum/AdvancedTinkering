using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using AdvancedTinkering;

namespace AdvancedTinkering.Items.Tools.Enchantments
{
    public class ConfusedEnchantment : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Confused Enchantment");
            Tooltip.SetDefault("Melee attacks inflict enemies with Confused.");
        }

        public override void SetDefaults()
        {
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
            recipe.AddIngredient(1346, 60);     //Nanites
            recipe.AddTile(233);                //Imbuing Station
            recipe.AddTile(412);                //Ancient Manipulator
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("ConfusedEnchantment"), 86400);
            return true;
        }
    }
}