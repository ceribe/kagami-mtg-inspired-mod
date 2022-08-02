using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Critical_Valor : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Critical Valor");
			Description.SetDefault("Your next hit will be critical.");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeCrit = 100;
            player.rangedCrit = 100;
            player.magicCrit = 100;
            player.thrownCrit = 100;
            player.AddBuff(mod.BuffType("Critical_Valor"), 2);
            if (player.GetModPlayer<KagamiPlayer>().Critted)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
