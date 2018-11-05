using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Pickaxes
{
    public class CobaltReaverShark : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Reaver Shark");
            Tooltip.SetDefault("Can mine Mythril and Orichalcum");
        }

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 21;
			item.useAnimation = 21;
			item.pick = 110;
            item.tileBoost++;
            item.useStyle = 1;
			item.knockBack = 5.50f;
			item.value = Item.buyPrice(0, 0, 2, 50);
            item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2341);             //Reaver Shark
            recipe.AddIngredient(null, "CobaltDust", 24);
            recipe.AddTile(null, "Tier2ForgeTile");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}