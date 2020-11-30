using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using ThisMod.Items.Weapons.Ranged.Projectiles;

namespace ThisMod.Items.Weapons.Ranged.Projectiles
{
	public class ExplosiveBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded bullet ammo.");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Projectiles.ExplosiveShotProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 20f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
	}
}