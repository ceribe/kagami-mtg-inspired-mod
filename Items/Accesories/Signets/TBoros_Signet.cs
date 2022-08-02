using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TBoros_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Boros Signet");
            Tooltip.SetDefault("Increse max life by 10 and movement speed by 10%");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 6000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.moveSpeed += 0.1f;
            player.statLifeMax2 += 10;
            player.AddBuff(mod.BuffType("Boros_Buff"), 2);
        }



        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Boros_Signet", 1);
            recipe.AddIngredient(null, "Boros_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}