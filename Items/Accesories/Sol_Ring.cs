using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Sol_Ring : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Sol Ring");
            Tooltip.SetDefault("Increses max mana by 100\n\" Lost to time is the artificer\'s art of trapping light from a distant star in a ring of purest gold.\"");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 2));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 50000;
			item.rare = 9;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                player.statManaMax2 += 100;
                Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 3f, 3f, 3f);

            }
        }

        public override void GrabRange(Player player, ref int grabRange)
        {
            grabRange *= 3;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }
    }
}