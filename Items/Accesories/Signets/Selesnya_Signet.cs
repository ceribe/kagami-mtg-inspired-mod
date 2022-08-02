using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class Selesnya_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("WG Signet");
            Tooltip.SetDefault("Increse max life by 5 and defense by 2");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 5000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.statLifeMax2 += 5;
            player.statDefense += 2;
		}

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Topaz, 1);
			recipe.AddIngredient(ItemID.Emerald, 1);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.Chairs);
            recipe.AddTile(TileID.Tables);
            recipe.SetResult(this);
			recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Topaz, 1);
            recipe2.AddIngredient(ItemID.Emerald, 1);
            recipe2.AddIngredient(ItemID.LeadBar, 1);
            recipe2.AddTile(TileID.Chairs);
            recipe2.AddTile(TileID.Tables);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}