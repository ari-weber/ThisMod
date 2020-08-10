using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items.Weapons.Meelee
{
	public class RazorSword: ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("RazorSword");
			Tooltip.SetDefault("Supa Sharp!");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

	

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 20);
			recipe.AddRecipeGroup("Wood", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}