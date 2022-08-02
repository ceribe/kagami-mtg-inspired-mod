using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Inner_Fire : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Inner Fire");
			Description.SetDefault("Increse all damage by 15% and reduce defense by 15");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense -= 15; ;
            player.meleeDamage += 0.15f;
            player.thrownDamage += 0.15f;
            player.rangedDamage += 0.15f;
            player.magicDamage += 0.15f;
            player.minionDamage += 0.15f;
            Dust.NewDust(player.position, player.width, player.height, 219, 0f, -2f, 150, default(Color), 1.5f);
            Dust.NewDust(player.position, player.width, player.height, 222, 0f, -2f, 150, default(Color), 1.5f);
        }
    }
}
