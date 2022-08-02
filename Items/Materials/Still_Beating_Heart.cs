using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Still_Beating_Heart : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Still Beating Heart");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 2));
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 5000;
            item.rare = 3;
        }

	}
}
