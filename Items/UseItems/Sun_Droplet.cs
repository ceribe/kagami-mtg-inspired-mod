using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	class Sun_Droplet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Sun Droplet");
            Tooltip.SetDefault("Permanently increases maximum life by 1\nCan be used 100 times per character");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 2));
        }

		public override void SetDefaults()
		{
            item.noUseGraphic = true;
            item.rare = 10;
            item.width = 16;
            item.height = 12;
            item.value = 5000;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
		{
			return player.GetModPlayer<KagamiPlayer>().UsedSunDroplets<100;
		}

		public override bool UseItem(Player player)
		{
			player.statLifeMax2++;
			player.statLife++;
			player.GetModPlayer<KagamiPlayer>().UsedSunDroplets++;
			return true;
		}
	}
}
