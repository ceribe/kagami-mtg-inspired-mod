using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Lazotep_Bullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lazotep Bullet");
            Main.projFrames[projectile.type] = 4;

        }

		public override void SetDefaults()
		{
			projectile.width = 4;              
			projectile.height = 4;              
			projectile.aiStyle = 1;             
			projectile.friendly = true;       
			projectile.hostile = false;        
			projectile.ranged = true;           
			projectile.penetrate = 1;         
			projectile.timeLeft = 200;        
			projectile.alpha = 255;           
			projectile.light = 0.7f;            
			projectile.ignoreWater = true;          
			projectile.tileCollide = false;          
			projectile.extraUpdates = 0;           
			aiType = ProjectileID.Bullet;           
		}
        public override void AI()
        {
            if (++projectile.frameCounter >= 5)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 4)
                {
                    projectile.frame = 0;
                }
            }
        }
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for (int d = 0; d < 5; d++)
            {
                Dust.NewDust(target.position, target.width, target.height, 41, 0f, 0f, 150, default(Color), 1.5f);
            }
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
