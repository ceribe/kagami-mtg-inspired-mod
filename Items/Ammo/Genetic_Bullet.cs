using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Ammo
{
	public class Genetic_Bullet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Genetic Bullet");
            Tooltip.SetDefault("Spawns critters on hit");
        }

		public override void SetDefaults()
		{
            item.damage = 8;
            item.ranged = true;
            item.width = 12;
            item.height = 12;
            item.maxStack = 9999;
            item.consumable = true;
            item.knockBack = 5f;
            item.value = 3;
            item.rare = 2;
            item.shoot = mod.ProjectileType("Genetic_Bullet");
			item.shootSpeed = 0.3f;
			item.ammo = AmmoID.Bullet;
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		/*public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Wrath, 300);
			}
		}*/

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Simic_Certificate", 1);
            recipe.AddIngredient(ItemID.MusketBall, 200);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 200);
			recipe.AddRecipe();
		}
	}
}
