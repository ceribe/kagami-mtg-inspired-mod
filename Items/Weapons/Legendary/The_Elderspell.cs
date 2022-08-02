using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons.Legendary
{
	public class The_Elderspell : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Elderspell");
            Tooltip.SetDefault("Legendary spell\nLMB & RMB unlocked post-Moon Lord\n\"The path to power is often paved with atrocities\"");
		}
		public override void SetDefaults()
		{
            item.damage = 20000;
            item.mana = 150;
            item.value = 2000000;
            item.rare = 11;
            item.shootSpeed = 35f;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 24;
            item.height = 28;
            item.shoot = 634;
            item.scale = 0.9f;
            item.knockBack = -5f;
            item.magic = true;
            item.glowMask = 207;

        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {
                for (int i = 0; i < 200; i++)
                {
                    NPC target = Main.npc[i];

                    float shootToX = target.position.X + target.width * 0.5f - player.Center.X;
                    float shootToY = target.position.Y + target.height * 0.5f - player.Center.Y;
                    float distance = (float)Math.Sqrt(shootToX * shootToX + shootToY * shootToY);

                    if (distance < 1000f && target.catchItem == 0 && !target.friendly && target.active && target.type != 488)
                    {
                        distance = 1.6f / distance;
                        shootToX *= distance * 3;
                        shootToY *= distance * 3;
                        Main.PlaySound(SoundID.Item8.WithVolume(.6f), player.position);
                        Projectile.NewProjectile(player.Center.X, player.Center.Y + 4, shootToX * 10, shootToY * 10, 634, item.damage, 6, Main.myPlayer, 0f, 0f);

                    }
                }
            }
            else
            {
                float numberProjectiles = 3;
                float rotation = MathHelper.ToRadians(1);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX * 3, speedY * 3).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }

            }
            return false;
        }
    }
}
