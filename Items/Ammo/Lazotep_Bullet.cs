using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Ammo
{
	public class Lazotep_Bullet : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Lazotep Bullet");
            Tooltip.SetDefault("Bullet made from Lazotep. Slow but, can go through walls");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 4));
        }

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 9999;
			item.consumable = true;
			item.knockBack = 5f;
			item.value = 25;
			item.rare = 7;
			item.shoot = mod.ProjectileType("Lazotep_Bullet");
			item.shootSpeed = 0.1f;
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
            recipe.AddIngredient(null, "Lazotep_Crystal", 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this, 200);
			recipe.AddRecipe();
		}
	}
}
