using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Legs : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Legs");
			Description.SetDefault("Increase move speed by 5% and negates fall damage");
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.05f;
            player.noFallDmg = true;

        }
    }
}
