using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Mutation_Brain : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Mutation: Brain");
			Description.SetDefault("Increse max mana by 20 and mana regen slightly");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statManaMax2 += 20;
            player.manaRegen += 1;
        }
    }
}
