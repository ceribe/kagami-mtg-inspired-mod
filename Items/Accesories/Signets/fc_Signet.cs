using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories.Signets
{
	public class fc_Signet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Rainbow Signet");
            Tooltip.SetDefault("Increse:\n-Max life by 10\n-Max mana by 10\n-All damage by 4%\n-Movement speed by 10%\n-Defense by 4");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(15, 5));

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 5000;
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
            player.statLifeMax2 += 10;
            player.statManaMax2 += 10;
            player.statDefense += 4;
            player.moveSpeed += 0.1f;

        }

        

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"MonoW_Signet", 1);
			recipe.AddIngredient(null,"MonoU_Signet", 1);
			recipe.AddIngredient(null,"MonoB_Signet", 1);
			recipe.AddIngredient(null,"MonoR_Signet", 1);
			recipe.AddIngredient(null,"MonoG_Signet", 1);
			recipe.AddIngredient(null,"Mana_Vortex", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
			recipe.AddRecipe();

        }
    }
}