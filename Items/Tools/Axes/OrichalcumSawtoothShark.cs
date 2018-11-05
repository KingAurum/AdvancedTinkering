using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.Items.Tools.Axes
{
	public class OrichalcumSawtoothSharkItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orichalcum Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            item.damage = 31;
            item.melee = true;
            item.width = 76;
            item.height = 22;
            item.useTime = 24;
            item.useAnimation = 24;
            item.channel = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.axe = 19;      //axe power *5
            item.tileBoost++;
            item.useStyle = 5;
            item.knockBack = 3.20f;
            item.value = Item.buyPrice(0, 2, 75, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("OrichalcumSawtoothSharkProjectile");
            item.shootSpeed = 60f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("AdvancedTinkering:SawtoothShark");
            recipe.AddIngredient(null, "OrichalcumDust", 18);
            recipe.AddTile(null, "Tier3ForgeTile");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }

    public class OrichalcumSawtoothSharkProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orichalcum Sawtooth Shark");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.SawtoothShark);
        }
    }
}
