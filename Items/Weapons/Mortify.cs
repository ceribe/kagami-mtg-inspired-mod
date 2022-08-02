using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons
{
	public class Mortify : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mortify");
            Tooltip.SetDefault("Deals damage to the nearest enemy");
		}

		public override void SetDefaults()
		{
            item.damage = 70;
            item.autoReuse = true;
            item.rare = 4;
            item.mana = 10;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 24;
            item.height = 28;
            item.knockBack = 3.5f;
            item.magic = true;
            item.value = 51000;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(null,"Orzhov_Certificate", 1);
            recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool UseItem(Player player)
        {
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];

                float shootToX = target.position.X + target.width * 0.5f - player.Center.X;
                float shootToY = target.position.Y + target.height * 0.5f - player.Center.Y;
                float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);

                if (distance < 400f && target.catchItem == 0 && !target.friendly && target.active && target.type != 488)
                {
                    Main.PlaySound(SoundID.Item28.WithVolume(.6f), player.position);
                    Projectile.NewProjectile(target.position.X + target.width * 0.5f, target.position.Y + target.height * 0.5f, 0, 0, 122, item.damage, 2, Main.myPlayer, 0f, 0f);
                    for (int d = 0; d < 200; d++)
                    {
                        Dust.NewDust(target.position, target.width, target.height, 63, 5f * d / 100, 0f, 150, default(Color), 1.5f);
                        Dust.NewDust(target.position, target.width, target.height, 64, -5f * d / 100, 0f, 150, default(Color), 1.5f);
                    }
                    break;
                }
            }
            return true;
        }
    }
}
