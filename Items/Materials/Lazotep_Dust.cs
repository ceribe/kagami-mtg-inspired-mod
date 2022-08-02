using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Lazotep_Dust : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lazotep Dust");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 1000;
            item.rare = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Lazotep_Crystal", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this,5);
            recipe.AddRecipe();
        }
    }
}
