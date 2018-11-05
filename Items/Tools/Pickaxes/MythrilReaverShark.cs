using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Pickaxes
{
    public class MythrilReaverShark : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Reaver Shark");
            Tooltip.SetDefault("Can mine Adamantite and Titanium");
        }

		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.width = 50;
			item.height = 56;
			item.useTime = 21;
			item.useAnimation = 21;
			item.pick = 150;
            item.tileBoost++;
            item.useStyle = 1;
			item.knockBack = 5.80f;
			item.value = Item.buyPrice(0, 0, 3, 0);
            item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(2341);             //Reaver Shark
            recipe.AddIngredient(null, "MythrilDust", 24);
            recipe.AddTile(null, "Tier3ForgeTile");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}