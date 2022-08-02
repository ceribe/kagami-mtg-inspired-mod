using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Hexproof_Weariness : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Hexproof Weariness");
			Description.SetDefault("You are need to wait before you can gain hexproof again");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
    }
}
