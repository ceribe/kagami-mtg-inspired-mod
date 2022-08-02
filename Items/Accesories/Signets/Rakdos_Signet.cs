using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class Rakdos_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("BR Signet");
            Tooltip.SetDefault("Increse damage by 2% and movement speed by 5%");

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
            player.meleeDamage += 0.02f;
            player.thrownDamage += 0.02f;
            player.rangedDamage += 0.02f;
            player.magicDamage += 0.02f;
            player.minionDamage += 0.02f;
            player.moveSpeed += 0.05f;

        }

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 1);
			recipe.AddIngredient(ItemID.Ruby, 1);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddTile(TileID.Chairs);
            recipe.AddTile(TileID.Tables);
            recipe.SetResult(this);
			recipe.AddRecipe();

            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(ItemID.Amethyst, 1);
            recipe2.AddIngredient(ItemID.Ruby, 1);
            recipe2.AddIngredient(ItemID.LeadBar, 1);
            recipe2.AddTile(TileID.Chairs);
            recipe2.AddTile(TileID.Tables);
            recipe2.SetResult(this);
            recipe2.AddRecipe();
        }
    }
}