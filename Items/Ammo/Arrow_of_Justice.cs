using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Ammo
{
	public class Arrow_of_Justice : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Arrow of Justice");
        }

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;
			item.knockBack = 5f;
			item.value = 5;
			item.rare = 2;
			item.shoot = mod.ProjectileType("Arrow_of_Justice");
			item.shootSpeed = 1f;
			item.ammo = AmmoID.Arrow;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Boros_Certificate", 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 200);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 200);
            recipe.AddRecipe();
        }
    }
}
