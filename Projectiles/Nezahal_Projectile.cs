using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Nezahal_Projectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Whirpool");
            Main.projFrames[projectile.type] = 3;

        }

		public override void SetDefaults()
		{
			projectile.width = 30;              
			projectile.height = 30;              
			projectile.aiStyle = 1;             
			projectile.friendly = false;       
			projectile.hostile = true;        
			projectile.magic = true;           
			projectile.penetrate = -1;         
			projectile.timeLeft = 1800;        
			projectile.alpha = 255;           
			projectile.light = 0.2f;            
			projectile.ignoreWater = true;          
			projectile.tileCollide = false;          
			aiType = ProjectileID.Bullet;  
			projectile.extraUpdates = 1;
        }

        public override void AI()
        {
            if (++projectile.frameCounter >= 4)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame >= 3)
                {
                    projectile.frame = 0;
                }
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
