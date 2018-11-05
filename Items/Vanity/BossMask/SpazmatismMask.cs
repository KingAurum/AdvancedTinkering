using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Vanity.BossMask
{
    [AutoloadEquip(EquipType.Head)]
    public class SpazmatismMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spazmatism Mask");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 22;
            item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 1;
            item.vanity = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2106);         //The Twins Mask
            recipe.AddTile(18);                 //Workbenches
            recipe.SetResult(this, 2);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(this, 2);
            recipe.AddTile(18);                 //Workbenches
            recipe.SetResult(2106);             //The Twins Mask
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "RetinazerMask");
            recipe.AddTile(18);                 //Workbenches
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}