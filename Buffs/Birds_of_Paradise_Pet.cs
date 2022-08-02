using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Birds_of_Paradise_Pet : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Birds of Paradise");
			Description.SetDefault("\"Each feather in its tail is a souvenir of an exotic land, a memory condensed in hue.\"");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
            player.statManaMax2 += 1;
			player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<KagamiPlayer>(mod).birdsPet = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Birds_of_Paradise")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Birds_of_Paradise"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}