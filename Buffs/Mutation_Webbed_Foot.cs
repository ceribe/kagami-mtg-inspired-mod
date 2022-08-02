using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Webbed_Foot : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Webbed Foot");
			Description.SetDefault("Provides ability to swim");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.accFlipper = true;
        }
    }
}
