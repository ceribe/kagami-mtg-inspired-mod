using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Claws : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Claws");
			Description.SetDefault("Increse all damage by 3%");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeDamage += 0.03f;
            player.thrownDamage += 0.03f;
            player.rangedDamage += 0.03f;
            player.magicDamage += 0.03f;
            player.minionDamage += 0.03f;
        }
    }
}
