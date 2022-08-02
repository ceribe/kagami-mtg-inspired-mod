using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
	public class High_Tide_Potion : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("High Tide Potion");
            Tooltip.SetDefault("Doubles mana regeneration");
        }
		public override void SetDefaults()
		{
            item.rare = -12;
            item.width = 24;
            item.height = 28;
            item.value = 200;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("High_Tide");
            item.buffTime = 60*60*5;
        }
	}
}
