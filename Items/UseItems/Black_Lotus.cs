using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Black_Lotus : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Lotus");
            Tooltip.SetDefault("The rarest of lotuses\n Gives Lotus Embrace buff");
        }
		public override void SetDefaults()
		{
            item.rare = 8;
            item.width = 24;
            item.height = 28;
            item.value = 50;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item25;
            item.useAnimation = 2;
            item.useTime = 10;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Lotus_Embrace");
            item.buffTime = 60*10;
        }

        public override bool UseItem(Player player)
        {
            return true;
        }

	}
}
