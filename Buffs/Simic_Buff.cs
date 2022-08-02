using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Simic_Buff : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Member of the Simic Combine");
			Description.SetDefault("You joined the Simic\nThis buff provides minor buffs in certain conditions");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.AddBuff(mod.BuffType("Blob_Buff"), 2);

            if (Main.rand.Next(0, 60 * 20) == 2)
            {
                player.statLife += 50;
                player.HealEffect(50, true);

            }

            if (Main.rand.Next(0, 60 * 20) == 2)
            {
                player.AddBuff((BuffID.Swiftness), 60*60);

            }

        }
    }
}
