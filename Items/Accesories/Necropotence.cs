using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Necropotence : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Huge power for a huge cost.\nGreatly reduces max life, life regen & defense, but increases all damage by 50%");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 6));
        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 100000;
			item.rare = 9;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                player.meleeDamage += 0.5f;
                player.thrownDamage += 0.5f;
                player.rangedDamage += 0.5f;
                player.magicDamage += 0.5f;
                player.minionDamage += 0.5f;
                player.statDefense = 0;
                player.lifeRegen = 0;
                
                player.lifeRegenCount = 0;
                player.lifeRegenTime = 0;
                player.statLifeMax2 = 200;
                if (player.statLife > 200) player.statLife = 200;

            }
		}
    }
}