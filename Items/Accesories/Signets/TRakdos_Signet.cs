using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TRakdos_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Rakdos Signet");
            Tooltip.SetDefault("Increse damage by 4% and movement speed by 10%");

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
            player.moveSpeed += 0.1f;
            player.AddBuff(mod.BuffType("Rakdos_Buff"), 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Rakdos_Signet", 1);
            recipe.AddIngredient(null, "Rakdos_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}