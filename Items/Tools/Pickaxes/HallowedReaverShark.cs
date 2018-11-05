using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Pickaxes
{
    public class HallowedReaverShark : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Reaver Shark");
            Tooltip.SetDefault("Capable of mining Chlorophyte ores");
        }

		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 21;
			item.useAnimation = 21;
			item.pick = 200;
            item.tileBoost += 2;
            item.useStyle = 1;
			item.knockBack = 6.40f;
			item.value = Item.buyPrice(0, 0, 4, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2341);             //Reaver Shark
            recipe.AddIngredient(null, "HallowedDust", 30);
            recipe.AddIngredient(547);              //Soul of Fright
            recipe.AddIngredient(548);              //Soul of Might
            recipe.AddIngredient(549);              //Soul of Sight
            recipe.AddTile(null, "Tier3ForgeTile");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}