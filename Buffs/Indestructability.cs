using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Indestructability : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Indestructability");
			Description.SetDefault("You are indestructible");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 99999;
            player.immune = true;
            player.noKnockback = true;
        }
    }
}
