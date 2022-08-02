using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Smothering_Tithe : ModItem
	{
        public static int counter = 0;

        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Smothering Tithe");
            Tooltip.SetDefault("Shoots at enemies when equipped");
        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 11000;
			item.rare = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            counter++;
            if (counter > 120)
            {
                counter = 0;
                for (int i = 0; i < 200; i++)
                {
                    NPC target = Main.npc[i];

                    float shootToX = target.position.X + target.width * 0.5f - player.Center.X;
                    float shootToY = target.position.Y + target.height * 0.5f - player.Center.Y;
                    float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);

                    if (distance < 700f && target.catchItem == 0 && !target.friendly && target.active && target.type != 488)
                    {
                        distance = 1.6f / distance;
                        shootToX *= distance * 3;
                        shootToY *= distance * 3;
                        Main.PlaySound(SoundID.Item8.WithVolume(.6f), player.position);
                        Projectile.NewProjectile(player.Center.X, player.Center.Y + 4, shootToX * 10, shootToY * 10, 122, 10, 6, Main.myPlayer, 0f, 0f);

                    }
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldCoin, 1);
            recipe.AddIngredient(null, "Orzhov_Certificate", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}