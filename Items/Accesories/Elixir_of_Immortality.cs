using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Elixir_of_Immortality : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Elixir of Immortality");
            Tooltip.SetDefault("Can occasionally fully heal you\n\"Bottled life. Not as tasty as I'm used to, rather stale, but it has the same effect.\"");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 15000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                if (Main.rand.Next(0, 60 * 180) == 1)
                {
                    player.statLife += 600000;
                    Main.PlaySound(SoundID.Item3);
                    for (int d = 0; d < 200; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 6, 0f, 0f, 150, default(Color), 1.5f);
                    }
                }
            }
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.AddIngredient(ItemID.JungleRose, 1);
            recipe.AddIngredient(null,"Blood", 200);
            recipe.AddIngredient(null, "Still_Beating_Heart", 1);
            recipe.AddTile(TileID.Chairs);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}