using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace KagamiMod.Projectiles
{
	public class Hexproof : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hexproof");
			projectile.light = 0.5f;
			Main.projFrames[projectile.type] = 2;
		}

		public override void SetDefaults()
		{
			projectile.width = 72;
			projectile.height = 72;
			projectile.penetrate = 200;
			projectile.timeLeft = 9999;
			projectile.tileCollide = false;
			projectile.hostile = false;
			projectile.friendly = false;
			projectile.alpha = 150;
		}
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			projectile.Center = player.Center;
			if (++projectile.frameCounter >= 10)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 2)
                {
                    projectile.frame = 0;
                }
            }
			
			if (player.dead || !player.HasBuff(mod.BuffType("Hexproof")))
			{
				projectile.Kill();
			}
		}
		
	}
}
