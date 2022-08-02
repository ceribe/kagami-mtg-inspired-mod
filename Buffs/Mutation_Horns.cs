using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Horns : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Horns");
			Description.SetDefault("Increase crit chance by 5%");
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeSpeed+=5;
            player.meleeCrit+=5;
            player.rangedCrit+=5;
            player.magicCrit+=5;
            player.thrownCrit+=5;
        }
    }
}
