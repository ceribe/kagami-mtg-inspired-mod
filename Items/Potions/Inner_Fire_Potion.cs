using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
	public class Inner_Fire_Potion : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Inner Fire Potion");
            Tooltip.SetDefault("Increse all damage by 15% and reduce defense by 15");
        }
		public override void SetDefaults()
		{
            item.rare = 4;
            item.width = 24;
            item.height = 28;
            item.value = 300;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Inner_Fire");
            item.buffTime = 60*60*5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.LivingFireBlock, 5);
            recipe.AddIngredient(ItemID.Fireblossom, 1);
            recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this,1);
			recipe.AddRecipe();
		}
	}
}
