using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Arrow_of_Justice : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arrow of Justice");
            Main.projFrames[projectile.type] = 1;
        }

		public override void SetDefaults()
		{
			projectile.width = 10;               //The width of projectile hitbox
			projectile.height = 10;              //The height of projectile hitbox
			projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.ranged = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.light = 1f;            //How much light emit around the projectile
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			projectile.extraUpdates = 1;            //Set to above 0 if you want the projectile to update multiple time in a frame
			aiType = ProjectileID.JestersArrow;           //Act exactly like default Bullet
            projectile.arrow = true;
		}
		
	}
}
