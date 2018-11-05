using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class CobaltSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 24;
            item.melee = true;
            item.width = 74;
            item.height = 22;
            item.useTime = 25;
            item.useAnimation = 25;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 16;      //axe power *5
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 2.75f;
            item.value = Item.buyPrice(0, 2, 50, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("CobaltSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "CobaltDust", 14);
            recipe.AddTile(null, "Tier2ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

    public class CobaltSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobalt Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
