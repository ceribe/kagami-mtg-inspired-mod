using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Indestructability_Weariness : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Indestructability Weariness");
			Description.SetDefault("You are need to wait before you can become indestructible again");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
    }
}
