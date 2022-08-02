using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons.Legendary
{
	public class Sword_of_War_and_Peace : ModItem
	{
        private short counter = 0;
        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Sword of War and Peace");
            Tooltip.SetDefault("Legendary Sword\nLMB & RMB unlocked post-Moon Lord\n\"Where is the peaceful part you ask? It heals.\"");  //The (English) text shown below your weapon's name
		}

		public override void SetDefaults()
		{
			item.damage = 30;           //The damage of your weapon
			item.melee = true;          //Is your weapon a melee weapon?
			item.width = 54;            //Weapon's texture's width
			item.height = 56;           //Weapon's texture's height
			item.useTime = 10;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 10;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 6;         //The force of knockback of the weapon. Maximum is 20
            item.value = 1000000;          //The value of the weapon
			item.rare = 12;              //The rarity of the weapon, from -1 to 13
			item.UseSound = SoundID.Item1;      //The sound when the weapon is using
			item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.shoot = 684;
            item.scale = 3f;
            item.shootSpeed = 50f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"Sword_of_War", 1);
            recipe.AddIngredient(null, "Sword_of_Peace", 1);
            recipe.AddIngredient(null, "Boros_Certificate", 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 60);
		}

        public override void HoldItem(Player player)
        {
            SetDefaults();
            counter++;
            if (counter == 60)
            {
                int heal = Main.rand.Next(3, 6);
                player.statLife += heal;
                player.HealEffect(heal, true);
                counter = 0;
            }
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
            if (player.altFunctionUse == 2)
            {
               
                type = 295;
                float numberProjectiles = 50;
                Vector2 target = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
                float ceilingLimit = target.Y;
                if (ceilingLimit > player.Center.Y - 200f)
                {
                    ceilingLimit = player.Center.Y - 200f;
                }
                for (int i = 0; i < 1; i++)
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
                   // Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI, 0f, ceilingLimit);

                }
                float rotation = MathHelper.ToRadians(180);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage*100, knockBack, player.whoAmI);
                }
            }
            else
            {

                damage = 25;
                float numberProjectiles = 3;
                float rotation = MathHelper.ToRadians(5);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }

                //betsys thingys
                type = 711;
                numberProjectiles = 5;
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
                    Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage * 2, knockBack, player.whoAmI, 0f, ceilingLimit);
                }
                //fireballs
                type = 15;
                numberProjectiles = 5;
                rotation = MathHelper.ToRadians(90);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
                //explosions
                type = 295;
                numberProjectiles = 2;
                rotation = MathHelper.ToRadians(20);
                position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
                for (int i = 0; i < numberProjectiles; i++)
                {
                    Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                    Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
                }
            }
            return false;
        }
	}
}
