using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Star_of_Extinction : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star of Extinction");
            Main.projFrames[projectile.type] = 3;
        }

		public override void SetDefaults()
		{
            projectile.width = 32;              
			projectile.height = 32;              
			projectile.aiStyle = 5;             
			projectile.friendly = true;       
			projectile.hostile = false;        
			projectile.ranged = true;           
			projectile.penetrate = 5;         
			projectile.timeLeft = 200;
            projectile.scale = 2f;
			projectile.alpha = 50;           
			projectile.light = 3f;            
			projectile.ignoreWater = false;          
			projectile.tileCollide = true;          
			projectile.extraUpdates = 0;           
			aiType = ProjectileID.Starfury;           
		}

        public override void AI()
        {
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 3)
                {
                    projectile.frame = 0;
                }
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            for (int d = 0; d < 200; d++)
            {
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 10f * d / 100, 0f, 150, default(Color), 1.5f);
                Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, -10f * d / 100, 0f, 150, default(Color), 1.5f);
            }
            projectile.Kill();
            return false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int d = 0; d < 200; d++)
            {
                Dust.NewDust(target.position, target.width, target.height, 60, 5f*d/100, 0f, 150, default(Color), 1.5f);
                Dust.NewDust(target.position, target.width, target.height, 60, -5f*d/100, 0f, 150, default(Color), 1.5f);
            }
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.Starfury;
            return true;
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			//Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}
