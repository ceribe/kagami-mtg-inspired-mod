using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Mystic_Remora : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Mystic Remora");
            Tooltip.SetDefault("Mana does not regenerate\n20% increased magic damage");

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
                player.magicDamage += 0.2f;
                player.manaRegen = 0;
                player.manaRegenCount = 0;
            }
		}
    }
}