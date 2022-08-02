using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Shared_Animosity : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("[c/FF5535:Shared Animosity]");
            Tooltip.SetDefault("Summon damage is multiplied by the number of summons");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 2));

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = -12;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
                player.minionDamage *= player.numMinions;
                for (int d = 0; d < player.numMinions/2; d++)
                {
                    Dust.NewDust(player.position, player.width, player.height, 244, 0f, 0f, 150, default(Color), 1.5f);
                }
		}
    }
}