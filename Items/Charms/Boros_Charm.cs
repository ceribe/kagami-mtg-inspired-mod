using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Charms
{
	public class Boros_Charm : ModItem
	{
        private short counter = 0;
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Boros Charm");
            Tooltip.SetDefault("LMB: Shoots a projectile\nRMB: Gives short indestructability\nWhen equipped may double damage of some attacks");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 3;
			item.accessory = true;
            item.damage = 12;
            item.mana = 10;
            item.value = 1000;
            item.shootSpeed = 30f;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.shoot = 15;
            item.scale = 0.9f;
            item.knockBack = 5f;
            item.magic = true;
        }

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            if (Main.rand.Next(0, 60 * 30) == 1)
            {
                player.AddBuff(mod.BuffType("Double_Strike"), 2);
            }

        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddIngredient(null, "Boros_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}