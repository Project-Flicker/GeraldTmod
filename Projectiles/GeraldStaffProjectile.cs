using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GeraldTmod.Projectiles
{
	public class GeraldStaffProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 4;
			projectile.magic = true;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 10;
			projectile.ai[0] = 0;
			projectile.timeLeft = 6000;
		}

		public override void AI() {
			projectile.damage = 300;
			if (projectile.position.X>Main.MouseWorld.X+1 || projectile.position.X<Main.MouseWorld.X-1) {
				if (Main.MouseWorld.X<projectile.position.X)
					projectile.velocity.X=-2f;
				if (Main.MouseWorld.X>projectile.position.X)
					projectile.velocity.X=2f;
			}
			if (projectile.position.Y>Main.MouseWorld.Y+1 || projectile.position.Y<Main.MouseWorld.Y-1) {
				if (Main.MouseWorld.Y<projectile.position.Y)
					projectile.velocity.Y=-2f;
				if (Main.MouseWorld.Y>projectile.position.Y)
					projectile.velocity.Y=2f;
			}
			if (projectile.position.Y>Main.MouseWorld.Y-1 && projectile.position.Y<Main.MouseWorld.Y+1)
				projectile.velocity.Y=0f;
			if (projectile.position.X>Main.MouseWorld.X-1 && projectile.position.X<Main.MouseWorld.X+1)
				projectile.velocity.X=0f;
			projectile.rotation = projectile.velocity.ToRotation();
		}
	}
}
