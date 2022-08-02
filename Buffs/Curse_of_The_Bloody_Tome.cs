using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Curse_of_The_Bloody_Tome : ModBuff
	{
        public override void SetDefaults()
		{
			DisplayName.SetDefault("Curse of the Bloody Tome");
			Description.SetDefault("You are cursed");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (Main.rand.Next(0, 14) == 1) player.statLife -= player.statLife / 100;
        }
    }
}
