using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles.Pets
{
	public class Blob : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blob");
			Main.projFrames[projectile.type] = 6;
			Main.projPet[projectile.type] = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
        }

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.BabySlime);
			aiType = ProjectileID.BabySlime;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.slime = false; // Relic from aiType
            projectile.minionSlots = 0;

            return true;
		}

	}
}