using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Scales : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Scales");
			Description.SetDefault("Increase defense by 4 and endurance by 4%");
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 4;
            player.endurance += 0.04f;

        }
    }
}
