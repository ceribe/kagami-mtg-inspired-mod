using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TOrzhov_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Orzhov Signet");
            Tooltip.SetDefault("Increse max life by 10 and damage by 4%");

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
            player.statLifeMax2 += 10;
            player.meleeDamage += 0.04f;
            player.thrownDamage += 0.04f;
            player.rangedDamage += 0.04f;
            player.magicDamage += 0.04f;
            player.minionDamage += 0.04f;
            player.AddBuff(mod.BuffType("Orzhov_Buff"), 2);
        }

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Orzhov_Signet", 1);
			recipe.AddIngredient(null,"Orzhov_Certificate", 1);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}