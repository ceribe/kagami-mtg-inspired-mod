using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Assemble_the_Legion2 : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Assemble the Legion I");
			Description.SetDefault("Increases your max number of minions by 2");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
    }
}
