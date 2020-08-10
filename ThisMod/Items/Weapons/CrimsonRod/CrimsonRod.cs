using IL.Terraria.ID;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items.Weapons.CrimsonRod
{
	public class CrimsonRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("CrimsonRod");
			Tooltip.SetDefault("Fun in Red.");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.magic = true;
			item.mana = 4;
            item.width = 40;
            item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = Terraria.ID.SoundID.Item20;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CrimsonOrb");
			item.shootSpeed = 16f;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(Terraria.ID.ItemID.Bone, 15);
			recipe.AddIngredient(Terraria.ID.ItemID.CursedFlame, 7);
			recipe.AddIngredient(Terraria.ID.ItemID.SoulofNight, 8);
			recipe.AddTile(Terraria.ID.TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}