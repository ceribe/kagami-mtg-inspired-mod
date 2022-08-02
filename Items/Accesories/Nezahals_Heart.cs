using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Nezahals_Heart : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Nezahal's Heart");
            Tooltip.SetDefault("You can move through water with ease\nProvides waterbreathing");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                player.ignoreWater = true;
                player.gills = true;
            }
		}
    }
}