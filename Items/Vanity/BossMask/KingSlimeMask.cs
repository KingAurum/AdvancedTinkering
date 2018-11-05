using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Vanity.BossMask
{
    [AutoloadEquip(EquipType.Head)]
    public class KingSlimeMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("King Slime Mask");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 1;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2493);         //King Slime Mask
            recipe.AddTile(18);                 //Workbenches
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this);
            recipe.AddTile(18);                 //Workbenches
            recipe.SetResult(2493);             //King Slime Mask
            recipe.AddRecipe();
        }
    }
}