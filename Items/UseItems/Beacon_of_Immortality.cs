using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	class Beacon_of_Immortality : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Beacon of Immortality");
            Tooltip.SetDefault("Doubles your max life permamently.\nCan be used only once");
		}

		public override void SetDefaults()
		{
            item.rare = -12;
            item.width = 24;
            item.height = 28;
            item.value = 5000000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
		{
			return NPC.downedMoonlord && player.GetModPlayer<KagamiPlayer>().UsedBeacon==0;
		}

		public override bool UseItem(Player player)
		{
			player.statLifeMax2 *= 2;
			player.statLife *= 2;
			player.GetModPlayer<KagamiPlayer>().UsedBeacon=1;
			return true;
		}
	}
}
