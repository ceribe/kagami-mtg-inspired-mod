using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Muscles : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Muscles");
			Description.SetDefault("Increase increse swing speed by 5% and grants immunity to knockback");
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.pickSpeed += 0.05f;
            player.tileSpeed += 0.05f;
            player.wallSpeed += 0.05f;
            player.meleeSpeed += 0.05f;
            player.noKnockback = true;
        }
    }
}
