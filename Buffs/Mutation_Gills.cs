using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Gills : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Gills");
			Description.SetDefault("Provides waterbreathing");
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.gills = true;
        }
    }
}
