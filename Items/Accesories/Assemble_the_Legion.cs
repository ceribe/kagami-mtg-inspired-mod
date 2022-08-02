using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Assemble_the_Legion : ModItem
	{
        public static int counter = 0;

        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Assemble the Legion");
            Tooltip.SetDefault("Every minute increses your maximum number of minions by 1 (up to 3)");
        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 11000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            if (counter<60*60*3+1) counter++;
            if (counter > 60*60 && counter<60*60*2)
            {
                player.maxMinions++;
                player.AddBuff(mod.BuffType("Assemble_the_Legion1"), 2);
            }
            if (counter >= 60 * 60*2 && counter<60*60*3)
            {
                player.maxMinions += 2;
                player.AddBuff(mod.BuffType("Assemble_the_Legion2"), 2);

            }
            if (counter >= 60 * 60*3)
            {
                player.maxMinions += 3;
                player.AddBuff(mod.BuffType("Assemble_the_Legion3"), 2);

            }
        }
    }
}