using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
	public class Test_Potion : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Test Potion");
            Tooltip.SetDefault("UNOBTAINABLE\nPOTION USED FOR TESTING");
        }
		public override void SetDefaults()
		{
            item.rare = 4;
            item.width = 24;
            item.height = 28;
            item.value = 300;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Hexproof");
            item.buffTime = 60*60*5;
        }
	}
}
