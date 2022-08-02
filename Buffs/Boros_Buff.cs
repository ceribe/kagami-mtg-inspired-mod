using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Boros_Buff : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Member of the Boros Legion");
			Description.SetDefault("You joined the Boros\nThis buff provides minor buffs in certain conditions");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (player.statLife <= player.statLifeMax2/20)
            {
                player.AddBuff(mod.BuffType("Furious_Resistance"), 2);

            }
            if (Main.rand.Next(0, 60 * 20) == 2)
            {
                player.AddBuff(mod.BuffType("Critical_Valor"), 2);
            }
            if (Main.rand.Next(0, 60 * 60) == 3 && player.statLife<100)
            {
                player.AddBuff(mod.BuffType("Heroic_Reinforcements"), Main.expertMode ? 60 * 15 : 60 * 30);

            }
        }
    }
}
