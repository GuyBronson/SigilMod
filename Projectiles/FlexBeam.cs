using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sigil.Projectiles
{
	public class FlexBeam : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flex Beam");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.TerraBeam);
			aiType = ProjectileID.TerraBeam;
		}

		public override bool PreKill(int timeLeft)
		{
			projectile.type = ProjectileID.TerraBeam;
			return true;
		}
	}
}