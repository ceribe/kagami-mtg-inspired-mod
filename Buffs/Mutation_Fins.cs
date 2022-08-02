using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Fins : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Fins");
			Description.SetDefault("Provides free movement in water");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.ignoreWater = true;
        }
    }
}
