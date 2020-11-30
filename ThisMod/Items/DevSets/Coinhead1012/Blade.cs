using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items.DevSets.Coinhead1012
{
	public class Blade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade of Punishment"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("daemonium surrecturus siet" + " \n -Coinhead1012");
		}
		public override void SetDefaults() 
		{
			item.damage = 999999999;
			item.melee = true;
			item.width = 50;
			item.height = 500;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 100;
			item.value = 10;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("Demonshot");
			item.shootSpeed = 20f;
		}
	}
}