using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TDimir_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Dimir Signet");
            Tooltip.SetDefault("Increse max mana by 10 and damage by 4%");

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
            player.meleeDamage += 0.04f;
            player.thrownDamage += 0.04f;
            player.rangedDamage += 0.04f;
            player.magicDamage += 0.04f;
            player.minionDamage += 0.04f;
            player.statManaMax2 += 10;
            player.AddBuff(mod.BuffType("Dimir_Buff"), 2);
        }



        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Dimir_Signet", 1);
            recipe.AddIngredient(null, "Dimir_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}