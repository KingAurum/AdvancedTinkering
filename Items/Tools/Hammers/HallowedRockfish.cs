using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Hammers
{
	public class HallowedRockfish : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Rockfish");
        }

        public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 42;
			item.height = 42;
			item.useTime = 24;
			item.useAnimation = 24;
			item.hammer = 80;
			item.useStyle = 1;
			item.knockBack = 7.35f;
			item.value = Item.buyPrice(0, 0, 2, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2320);             //Rockfish
            recipe.AddIngredient(null, "HallowedDust", 24);
            recipe.AddTile(null, "Tier3ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
