using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class HallowedSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.melee = true;
            item.width = 74;
            item.height = 22;
            item.useTime = 24;
            item.useAnimation = 24;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 22;      //axe power *5
            item.tileBoost += 2;
            item.useStyle = 5;
            item.knockBack = 3.65f;
            item.value = Item.buyPrice(0, 4, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("HallowedSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "HallowedDust", 30);
            recipe.AddIngredient(547);              //Soul of Fright
            recipe.AddIngredient(548);              //Soul of Might
            recipe.AddIngredient(549);              //Soul of Sight
            recipe.AddTile(null, "Tier3ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

    public class HallowedSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hallowed Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
