using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class TGolgari_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Golgari Signet");
            Tooltip.SetDefault("Increse damage by 4% and defense by 4");

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
            player.statDefense += 4;
            player.AddBuff(mod.BuffType("Golgari_Buff"), 2);
        }



        public override void AddRecipes()
		{
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Golgari_Signet", 1);
            recipe.AddIngredient(null, "Golgari_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}