using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Projectiles.Pets
{
	public class Birds_of_Paradise : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Birds of Paradise");
			Main.projFrames[projectile.type] = 5;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			KagamiPlayer modPlayer = player.GetModPlayer<KagamiPlayer>(mod);
			if (player.dead)
			{
                modPlayer.birdsPet = false;
			}
			if (modPlayer.birdsPet)
			{
				projectile.timeLeft = 2;
			}
		}
	}
}