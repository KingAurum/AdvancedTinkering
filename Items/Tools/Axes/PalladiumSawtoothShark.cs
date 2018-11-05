using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class PalladiumSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.melee = true;
            item.width = 76;
            item.height = 22;
            item.useTime = 24;
            item.useAnimation = 24;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 17;      //axe power *5
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 2.90f;
            item.value = Item.buyPrice(0, 2, 50, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PalladiumSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "PalladiumDust", 18);
            recipe.AddTile(null, "Tier2ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }

    public class PalladiumSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Palladium Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
