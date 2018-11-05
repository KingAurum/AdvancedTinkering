using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class AdamantiteSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adamantite Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 33;
            item.melee = true;
            item.width = 74;
            item.height = 22;
            item.useTime = 24;
            item.useAnimation = 24;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 20;      //axe power *5
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 3.35f;
            item.value = Item.buyPrice(0, 3, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("AdamantiteSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "AdamantiteDust", 18);
            recipe.AddTile(null, "Tier3ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

    public class AdamantiteSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Adamantite Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
