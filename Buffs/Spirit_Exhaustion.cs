using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Spirit_Exhaustion : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Spirit Exhaustion");
			Description.SetDefault("Your lifefore was transfered recently.");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
            canBeCleared = false;
        }
	}
}
