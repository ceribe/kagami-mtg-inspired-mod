using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Furious_Resistance : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Furious Resistance");
			Description.SetDefault("Increse damage by 5% and defense by 5");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 5;
            player.meleeDamage += 0.05f;
            player.thrownDamage += 0.05f;
            player.rangedDamage += 0.05f;
            player.magicDamage += 0.05f;
        }
    }
}
