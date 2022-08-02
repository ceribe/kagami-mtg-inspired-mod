using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Bouncer : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bouncer");
            Main.projFrames[projectile.type] = 1;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5; 
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }

		public override void SetDefaults()
		{
			projectile.width = 4;              
			projectile.height = 4;              
			projectile.aiStyle = 1;             
			projectile.friendly = true;       
			projectile.hostile = false;        
			projectile.magic = true;           
			projectile.penetrate = 1;         
			projectile.timeLeft = 200;        
			projectile.alpha = 50;           
			projectile.light = 0.7f;            
			projectile.extraUpdates = 3;           
			aiType = ProjectileID.MagicMissile;           
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
