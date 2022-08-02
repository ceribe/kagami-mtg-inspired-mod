using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Charms
{
	public class Simic_Charm : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Simic Charm");
            Tooltip.SetDefault("LMB: Shoots a high-knockback projectile\nRMB: Gives hexproof for 5s\nWhen equipped increase max life by 10 and all damage by 5%");

        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 3;
			item.accessory = true;
            item.damage = 1;
            item.mana = 5;
            item.value = 1000;
            item.shootSpeed = 50f;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.shoot = mod.ProjectileType("Bouncer");
            item.scale = 0.9f;
            item.knockBack = 500f;
            item.magic = true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
		{
            player.statLifeMax2 += 10;
            player.meleeDamage += 0.05f;
            player.thrownDamage += 0.05f;
            player.rangedDamage += 0.05f;
            player.magicDamage += 0.05f;
            player.minionDamage += 0.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 1);
            recipe.AddIngredient(null, "Simic_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}