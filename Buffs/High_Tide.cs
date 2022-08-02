using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class High_Tide : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("High Tide");
			Description.SetDefault("Mana regeneration is doubled");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.manaRegen *= 2;
            player.manaRegenCount *= 2;
        }
    }
}
