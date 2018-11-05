using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Pickaxes
{
    public class ChlorophyteReaverShark : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Reaver Shark");
            Tooltip.SetDefault("Capable of mining Lihzahrd Bricks");
        }

		public override void SetDefaults()
		{
			item.damage = 42;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 21;
			item.useAnimation = 21;
			item.pick = 210;
            item.tileBoost += 2;
            item.useStyle = 1;
			item.knockBack = 6.55f;
			item.value = Item.buyPrice(0, 0, 5, 0);
            item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2341);             //Reaver Shark
            recipe.AddIngredient(null, "ChlorophyteDust", 30);
            recipe.AddIngredient(2218, 15);         //Beetle Husk
            recipe.AddTile(null, "Tier4ForgeTile");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}