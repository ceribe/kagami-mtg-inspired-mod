using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TAzorius_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Azorius Signet");
            Tooltip.SetDefault("Increse max life by 10 and max mana by 10");

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
            player.statManaMax2 += 10;
            player.AddBuff(mod.BuffType("Azorius_Buff"), 2);

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Azorius_Signet", 1);
            recipe.AddIngredient(null, "Azorius_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}