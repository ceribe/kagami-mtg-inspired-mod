using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Lazotep_Plating : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Lazotep Plating");
            Tooltip.SetDefault("Increases max life by 100 and defense by 10, but reduces movement speed by 30%");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 65000;
			item.rare = 7;
			item.accessory = true;
            item.defense = 10;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                player.statLifeMax2 += 100;
                player.statDefense += 10;
                player.moveSpeed = 0.7f * player.moveSpeed;
                if (Main.rand.Next(0, 5) == 1)
                {
                    for (int d = 0; d < 1; d++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 41, 0f, 0f, 150, default(Color), 1.5f);
                    }
                }
            }
		}

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(null, "Lazotep_Dust", 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}