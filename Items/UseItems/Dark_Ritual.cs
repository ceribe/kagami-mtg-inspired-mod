using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Dark_Ritual : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Ritual");
            Tooltip.SetDefault("Fully restores mana");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 20000;
            item.maxStack = 9999;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useStyle = 4;
            item.mana = 5;
            item.UseSound = SoundID.Item122;
            item.consumable = true;

        }

        public override bool UseItem(Player player)
        {
            player.statMana += 1000;
            for (int d = 0; d < 200; d++)
            {
                Dust.NewDust(player.position, player.width, player.height, 191, 0f, 0f, 150, default(Color), 1.5f);
            }
            return true;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ObsidianSkull,4);
            recipe.AddIngredient(ItemID.SoulofNight, 1);
            recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}
	}
}
