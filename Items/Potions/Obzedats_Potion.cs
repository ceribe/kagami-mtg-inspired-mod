using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
	public class Obzedats_Potion : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Obzedat's Potion");
            Tooltip.SetDefault("Slightly increase ALL stats");
        }
		public override void SetDefaults()
		{
            item.rare = 3;
            item.width = 24;
            item.height = 28;
            item.value = 200;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Obzedats_Aid");
            item.buffTime = 60*60*5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 5);
            recipe.AddIngredient(null, "Orzhov_Certificate", 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}
