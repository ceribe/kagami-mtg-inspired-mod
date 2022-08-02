using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Culling_Sun : ModItem
	{

        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Culling Sun");
            Tooltip.SetDefault("Weak enemies instantly die when nearby");
        }

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 5000;
			item.rare = 5;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];
                if (target.lifeMax <= 200)
                {
                    float shootToX = target.position.X + target.width * 0.5f - player.Center.X;
                    float shootToY = target.position.Y + target.height * 0.5f - player.Center.Y;
                    float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);

                    if (distance < 400f && target.catchItem == 0 && !target.friendly && target.active && target.type != 488)
                    {
                        target.life -= target.life - 1;
                        Projectile.NewProjectile(target.position.X + target.width * 0.5f, target.position.Y + target.height * 0.5f, 0, 0, 122, 1, 2, Main.myPlayer, 0f, 0f);
                        Lighting.AddLight((int)((double)target.position.X + (double)(target.width / 2)) / 16, (int)((double)target.position.Y + (double)(target.height / 2)) / 16, 2f, 2f, 2f);
                    }
                }
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(null, "Orzhov_Certificate", 5);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}