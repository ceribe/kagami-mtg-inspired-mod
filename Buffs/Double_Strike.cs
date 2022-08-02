using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Double_Strike : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Double Strike");
			Description.SetDefault("Your next hit will be doubled.");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
            Main.persistentBuff[Type] = true;
            canBeCleared = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.AddBuff(mod.BuffType("Double_Strike"), 2);
            if (player.GetModPlayer<KagamiPlayer>().DSed)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}
