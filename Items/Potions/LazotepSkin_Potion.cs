using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
	public class LazotepSkin_Potion : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lazotepskin Potion");
            Tooltip.SetDefault("Increse defense by 10 and max life by 30");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
        }
		public override void SetDefaults()
		{
            item.noUseGraphic = true;
            item.rare = 7;
            item.width = 24;
            item.height = 28;
            item.value = 5000000; //TODO
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 10;
            item.useTime = 10;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Lazotepskin");
            item.buffTime = 60*60*5;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ItemID.Daybloom, 1);
            recipe.AddIngredient(null, "Lazotep_Dust", 1);
            recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
