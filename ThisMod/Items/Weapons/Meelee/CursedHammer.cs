using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items.Weapons.Meelee
{
	public class CursedHammer : ModItem
	{
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
		{
			target.AddBuff(BuffID.CursedInferno, 120); // The '60' here is the duration in miliseconds.
		}
		public override void SetStaticDefaults() 
		{
			//DisplayName.SetDefault("CursedHammer");
			Tooltip.SetDefault("Cursed by a powerful being, to never act as a hammer.");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 9;
			item.value = 10000;
			item.rare = ItemRarityID.LightRed;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 15);
			recipe.AddIngredient(ItemID.CursedFlame, 7);
			recipe.AddIngredient(ItemID.SoulofNight, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}