using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Hard_Mode : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("One with Nothing");
            Tooltip.SetDefault("Right click to begin Hardmode\nTHE EFFECT IS IRREVERSIBLE");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 3));
        }
		public override void SetDefaults()
		{
            item.rare = -12;
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.maxStack = 1;
            item.consumable = true;

        }
        public override bool CanRightClick()
        {
            return !Main.hardMode;
        }

        public override void RightClick(Player player)
        {
                Main.hardMode = true;
                Main.NewText("Hardmode is active. Good luck.", 200, 10, 200);
                Main.PlaySound(SoundID.Roar, player.position, 0);
        }
	}
}
