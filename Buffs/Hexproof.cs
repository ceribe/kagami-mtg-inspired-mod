using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace KagamiMod.Buffs
{
	public class Hexproof : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Hexproof");
			Description.SetDefault("Projectiles cannot hit you.");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[mod.ProjectileType("Hexproof")] == 0)
            {
                Vector2 vel = new Vector2(0, -1);
                vel *= 0f;
                Projectile.NewProjectile(player.position.X - 15, player.position.Y, vel.X, vel.Y, mod.ProjectileType("Hexproof"), 0, 0, player.whoAmI);
            }
        }
    }
}
