using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Genetic_Bullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Genetic Bullet");
        }

		public override void SetDefaults()
		{
			projectile.width = 4;              
			projectile.height = 4;              
			projectile.aiStyle = 1;             
			projectile.friendly = true;       
			projectile.hostile = false;        
			projectile.ranged = true;           
			projectile.penetrate = 2;         
			projectile.timeLeft = 200;        
			projectile.alpha = 255;           
			projectile.ignoreWater = false;          
			projectile.tileCollide = true;          
			projectile.extraUpdates = 0;           
			aiType = ProjectileID.Bullet;           
		}

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            int r = Main.rand.Next(0, 23);
            switch (r)
            {
                case 0:  NPC.NewNPC((int)target.position.X, (int)target.position.Y, 74);break;
                case 1:  NPC.NewNPC((int)target.position.X, (int)target.position.Y, 297);break;
                case 2:  NPC.NewNPC((int)target.position.X, (int)target.position.Y, 366);break;
                case 3: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 487); break;
                case 4: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 46); break;
                case 5: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 298); break;
                case 6: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 364); break;
                case 7: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 355); break;
                case 8: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 361); break;
                case 9: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 360); break;
                case 10: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 55); break;
                case 11: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 377); break;
                case 12: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 485); break;
                case 13: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 358); break;
                case 14: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 362); break;
                case 15: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 300); break;
                case 16: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 148); break;
                case 17: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 538); break;
                case 18: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 367); break;
                case 19: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 486); break;
                case 20: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 359); break;
                case 21: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 299); break;
                case 22: NPC.NewNPC((int)target.position.X, (int)target.position.Y, 357); break;


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
