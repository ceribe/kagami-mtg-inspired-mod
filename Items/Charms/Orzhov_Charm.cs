using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Charms
{
	public class Orzhov_Charm : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Orzhov Charm");
            Tooltip.SetDefault("Increase max number of minions by 1 when equipped");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 3;
			item.accessory = true;
            item.damage = 20;
            item.mana = 10;
            item.value = 1000;
            item.shootSpeed = 15f;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.shoot = 92;
            item.scale = 0.9f;
            item.knockBack = 5f;
            item.magic = true;
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.maxMinions++;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddIngredient(null, "Orzhov_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}