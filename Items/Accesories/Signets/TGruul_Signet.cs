using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TGruul_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Gruul Signet");
            Tooltip.SetDefault("Increse movement speed by 10% and defense by 4");

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
            player.statDefense += 4;
            player.AddBuff(mod.BuffType("Gruul_Buff"), 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Gruul_Signet", 1);
            recipe.AddIngredient(null, "Gruul_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}