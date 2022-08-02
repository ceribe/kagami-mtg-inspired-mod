using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Lazotepskin : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Lazotepskin");
			Description.SetDefault("Increase defense by 10 and max life by 30");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 10;
            player.statLifeMax2 += 30;
        }
    }
}
