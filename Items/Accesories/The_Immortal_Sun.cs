using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class The_Immortal_Sun : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("The Immortal Sun");
            Tooltip.SetDefault("Night stops to exist\nMax life is increased by 50 and all damage by 10%");
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 50000;
			item.rare = 20;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                Main.dayTime = true;
                if(Main.time==Main.dayLength-1) Main.time = 0;
                player.statLifeMax2 += 50;
                player.meleeDamage += 0.1f;
                player.thrownDamage += 0.1f;
                player.rangedDamage += 0.1f;
                player.magicDamage += 0.1f;
                player.minionDamage += 0.1f;
                Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 10f, 10f, 10f);

            }
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddIngredient(null, "Sun_Droplet", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}