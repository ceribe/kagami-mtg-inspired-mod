using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons.Legendary
{
    public class Star_of_Extinction : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star of Extinction");
            Tooltip.SetDefault("Legendary Bow\nLMB & RMB unlocked post-Moon Lord\n\"It's sooo big\"\n90% chance to not consume ammo");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 35;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10f;
            item.value = Item.sellPrice(0, 10, 0, 0);
            item.rare = 13;
            
            item.autoReuse = true;
            item.shoot = 41;
            item.scale = 6f;
            item.shootSpeed = 40f;
            item.useAmmo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DD2PhoenixBow, 1);
            recipe.AddIngredient(ItemID.DD2BetsyBow, 1);
            recipe.AddIngredient(ItemID.Tsunami, 1);
            recipe.AddIngredient(ItemID.HellwingBow, 1);
            recipe.AddIngredient(ItemID.TendonBow, 1);
            recipe.AddIngredient(ItemID.HellfireArrow, 9999);
            recipe.AddIngredient(ItemID.LunarBar, 50);
            recipe.AddIngredient(ItemID.HellstoneBar, 50);
            recipe.AddIngredient(ItemID.MeteoriteBar, 50);
            recipe.AddIngredient(ItemID.HallowedBar, 50);
            recipe.AddIngredient(ItemID.LivingFireBlock, 200);
            recipe.AddIngredient(ItemID.FragmentSolar, 100);
            recipe.AddIngredient(ItemID.Obsidian, 500);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void GetWeaponDamage(Player player, ref int damage)
        {
            damage = (int)(damage * player.bulletDamage + 5E-06);
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useTime = 70;
                item.useStyle = 4;
                item.shootSpeed = 10f;
                item.useAnimation = 70;
                item.UseSound = SoundID.Item4;
            }
            else
            {
                item.useAnimation = 35;
                item.UseSound = SoundID.Item5;
                item.shootSpeed = 40f;
                item.useTime = 10;
                item.useStyle = 5;

            }
            return base.CanUseItem(player);
        }

        public override Vector2? HoldoutOffset()
        {
            return Vector2.Zero;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .9f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (player.altFunctionUse == 2)
            {


                type = mod.ProjectileType("Star_of_Extinction");
                Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
                float ceilingLimit = target.Y;
                if (ceilingLimit > player.Center.Y - 200f)
                {
                    ceilingLimit = player.Center.Y - 200f;
                }
                for (int i = 0; i < 3; i++)
                {
                    position = player.Center + new Vector2((-(float)Main.rand.Next(0, 401) * player.direction), -600f);
                    position.Y -= (100 * i);
                    Vector2 heading = target - position;
                    if (heading.Y < 0f)
                    {
                        heading.Y *= -1f;
                    }
                    if (heading.Y < 20f)
                    {
                        heading.Y = 20f;
                    }
                    heading.Normalize();
                    heading *= new Vector2(speedX, speedY).Length();
                    speedX = heading.X;
                    speedY = heading.Y + Main.rand.Next(-40, 41) * 0.02f;
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 1000, knockBack, player.whoAmI, 0f, ceilingLimit);
                }
            }
            else
            {
                type = ProjectileID.DD2PhoenixBowShot;
                float numberProjectiles = 30;
                
                float rotation = MathHelper.ToRadians(90);
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
