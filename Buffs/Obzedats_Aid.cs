using Terraria;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
	public class Obzedats_Aid : ModBuff
	{

        public override void SetDefaults()
		{
			DisplayName.SetDefault("Obzedat's Aid");
			Description.SetDefault("Obzedat blessed you. ALL stats are slightly incresed.");
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statDefense += 1;
            player.statLifeMax2 += 1;
            player.statManaMax2 += 1;
            player.lifeRegen += 1;
            player.manaRegen += 1;
            player.meleeDamage += 0.01f;
            player.thrownDamage += 0.01f;
            player.rangedDamage += 0.01f;
            player.magicDamage += 0.01f;
            player.minionDamage += 0.01f;
            player.moveSpeed += 0.01f;
            player.pickSpeed += 0.01f;
            player.tileSpeed += 0.01f;
            player.wallSpeed += 0.01f;
            player.meleeSpeed += 0.01f;
            player.jumpSpeedBoost += 0.01f;
            player.meleeSpeed++;
            player.meleeCrit++;
            player.rangedCrit++;
            player.magicCrit++;
            player.thrownCrit++;
            player.wingTimeMax += 1;
            player.endurance += 0.01f;
        }
    }
}
