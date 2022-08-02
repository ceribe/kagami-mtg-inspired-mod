using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Blob_Buff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Blob");
			Description.SetDefault("Summons a blob that will try to fight for you, however it's to weak to even deal damage");
            Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<KagamiPlayer>(mod).blob = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("Blob")] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("Blob"), 5, 0f, player.whoAmI);
			}
		}
	}
}