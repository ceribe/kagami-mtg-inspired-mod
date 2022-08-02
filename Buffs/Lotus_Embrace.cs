using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Lotus_Embrace : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Lotus Embrace");
			Description.SetDefault("Your mana is unlimited.");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statMana += 600000;
            player.statManaMax2 = 400;
        }
    }
}
