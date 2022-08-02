using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Swords_to_Plowshares : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Swords to Plowshares");
            Tooltip.SetDefault("Channels mana regeneration into life regeneration\nReduce all damage by 90%");
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
                if (player.statLife < player.statLifeMax2)
                {
                    player.lifeRegen += player.manaRegen / 5;
                    player.manaRegen = 0;
                    player.manaRegenCount = 0;
                }
                player.meleeDamage *= 0.1f;
                player.thrownDamage *= 0.1f;
                player.rangedDamage *= 0.1f;
                player.magicDamage *= 0.1f;
                player.minionDamage *= 0.1f;
		}

    }
}