using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Lazotep_Crystal : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lazotep Crystal");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 5000;
            item.rare = 7;
        }
    }
}
