using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Pickaxes
{
    public class TitaniumReaverShark : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titanium Reaver Shark");
        }

		public override void SetDefaults()
		{
			item.damage = 21;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 21;
			item.useAnimation = 21;
			item.pick = 190;
            item.tileBoost++;
            item.useStyle = 1;
			item.knockBack = 6.25f;
			item.value = Item.buyPrice(0, 0, 3, 50);
            item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2341);             //Reaver Shark
            recipe.AddIngredient(null, "TitaniumDust", 34);
            recipe.AddTile(null, "Tier3ForgeTile");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}