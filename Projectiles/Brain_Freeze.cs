using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles
{
	public class Brain_Freeze : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brain Freeze");
            Main.projFrames[projectile.type] = 1;
        }

		public override void SetDefaults()
		{
			projectile.width = 6;               //The width of projectile hitbox
			projectile.height = 6;              //The height of projectile hitbox
			projectile.aiStyle = 1;             //The ai style of the projectile, please reference the source code of Terraria
			projectile.friendly = true;         //Can the projectile deal damage to enemies?
			projectile.hostile = false;         //Can the projectile deal damage to the player?
			projectile.magic = true;           //Is the projectile shoot by a ranged weapon?
			projectile.penetrate = 1;           //How many monsters the projectile can penetrate. (OnTileCollide below also decrements penetrate for bounces as well)
			projectile.timeLeft = 600;          //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.ignoreWater = false;          //Does the projectile's speed be influenced by water?
			projectile.tileCollide = true;          //Can the projectile collide with tiles?
			aiType = ProjectileID.IceSpike;           //Act exactly like default Bullet
		}
		
	}
}
