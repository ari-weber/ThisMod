using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ThisMod.Items.Weapons.CrimsonRod
{
	public class CrimsonOrb : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			//DisplayName.SetDefault("English Display Name Here");
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 29;
			projectile.friendly = true;
			projectile.ranged = true;
			aiType = ProjectileID.WoodenArrowFriendly;
		}

		// Additional hooks/methods here.
	}
}