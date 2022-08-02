using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Buffs
{
    public class Heroic_Reinforcements : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Heroic_Reinforcements");
            Description.SetDefault("Increases your max number of minions by 2 and defense by 5");
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.maxMinions += 2;
            player.statDefense += 5;
        }
    }
}
