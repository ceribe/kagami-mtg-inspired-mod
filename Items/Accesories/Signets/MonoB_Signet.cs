using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class MonoB_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Black Signet");
            Tooltip.SetDefault("Increse damage by 4%");

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
            player.meleeDamage += 0.04f;
            player.thrownDamage += 0.04f;
            player.rangedDamage += 0.04f;
            player.magicDamage += 0.04f;
            player.minionDamage += 0.04f;

        }

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 2);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.Chairs);
            recipe.AddTile(TileID.Tables);
            recipe.SetResult(this);
			recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Amethyst, 2);
            recipe2.AddIngredient(ItemID.LeadBar, 1);
            recipe2.AddTile(TileID.Chairs);
            recipe2.AddTile(TileID.Tables);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}