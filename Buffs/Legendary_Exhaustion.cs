using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Legendary_Exhaustion : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Legendary Fatigue");
			Description.SetDefault("You need recovery before you can use legendary powers again");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
            canBeCleared = false;
        }

	}
}
