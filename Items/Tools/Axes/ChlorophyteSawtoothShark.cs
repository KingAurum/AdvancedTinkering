using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class ChlorophyteSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 34;
            item.melee = true;
            item.width = 78;
            item.height = 22;
            item.useTime = 24;
            item.useAnimation = 24;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 25;      //axe power *5
            item.tileBoost += 2;
            item.useStyle = 5;
            item.knockBack = 3.80f;
            item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 7;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("ChlorophyteSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "ChlorophyteDust", 30);
            recipe.AddIngredient(2218, 15);         //Beetle Husk
            recipe.AddTile(null, "Tier4ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }

    public class ChlorophyteSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
