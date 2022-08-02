using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Wings : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Wings");
			Description.SetDefault("Increse flight time by 20");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.wingTimeMax += 20;
        }
    }
}
