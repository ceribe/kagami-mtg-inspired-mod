using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Orzhov_Buff : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Member of the Orzhov Sindicate");
			Description.SetDefault("You joined the Orzhov\nThis buff provides minor buffs in certain conditions");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if(Main.rand.Next(0, 60*60*2)==1)
            {
                if (player.statLife > 100) player.statLife -= 100;
                Main.PlaySound(38, player.position, 0);
            }
            if(Main.rand.Next(0, 60 * 60) == 2)
            {
                player.AddBuff(mod.BuffType("Obzedats_Aid"), Main.expertMode ? 60 * 15 : 60 * 30);
            }
            if (Main.rand.Next(0, 60 * 60) == 3)
            {
                player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(1, 5));
            }
        }
    }
}
