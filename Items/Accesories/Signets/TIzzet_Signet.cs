using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TIzzet_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Izzet Signet");
            Tooltip.SetDefault("Increse max mana by 10 and movement speed by 10%");

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
            player.statManaMax2 += 10;
            player.moveSpeed += 0.1f;
            player.AddBuff(mod.BuffType("Izzet_Buff"), 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Izzet_Signet", 1);
            recipe.AddIngredient(null, "Izzet_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}