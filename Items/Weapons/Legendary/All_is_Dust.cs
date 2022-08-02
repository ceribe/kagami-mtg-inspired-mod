using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons.Legendary
{
	public class All_is_Dust : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("All is Dust");
            Tooltip.SetDefault("Legendary spell\nLMB unlocked post-Moon Lord");
		}
		public override void SetDefaults()
		{
            item.damage = 300;
            item.mana = 300;
            item.value = 2000000;
            item.rare = 11;
            item.useStyle = 5;
            item.noMelee = true;
            item.autoReuse = true;
            item.UseSound = SoundID.Item8;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 24;
            item.height = 28;
            item.shoot = 704;
            item.scale = 0.9f;
            item.knockBack = -5f;
            item.magic = true;

        }

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.DarkShard, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 50);
            recipe.AddIngredient(null,"Bottled_Darkness", 50);
            recipe.AddTile(TileID.Bookcases);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && NPC.downedMoonlord;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            Projectile.NewProjectile(position.X, position.Y, 0, 0, 696, 0, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X+20, position.Y, 0, 0, 696, 0, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X-20, position.Y, 0, 0, 696, 0, knockBack, player.whoAmI);
            for (int d = 0; d < 500; d++)
            {
                Dust.NewDust(player.position, player.width, player.height+50, 63, 3f * (Main.rand.Next(1, 1000) / 100f), 5f * (Main.rand.Next(1, 1000) / 100f), 150, default(Color), 1.5f);
                Dust.NewDust(player.position, player.width, player.height+50, 63, (-1)*3f * (Main.rand.Next(1, 1000) / 100f), 5f * (Main.rand.Next(1, 1000) / 100f), 150, default(Color), 1.5f);
                Dust.NewDust(player.position, player.width, player.height, 63, 3f * (Main.rand.Next(1, 1000) / 100f), (-1)*5f * (Main.rand.Next(1, 1000) / 100f), 150, default(Color), 1.5f);
                Dust.NewDust(player.position, player.width, player.height, 63, (-1)*3f*(Main.rand.Next(1,1000)/100f), (-1)*5f * (Main.rand.Next(1, 1000) / 100f), 150, default(Color), 1.5f);
            }
            for (int i = 1; i < 20; i++)
            {
                Projectile.NewProjectile(position.X, position.Y, 18f*i*0.02f, speedY, type, damage, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, 18f*i*(-1)*0.02f, speedY, type, damage, knockBack, player.whoAmI);
            }

            return false;
        }
    }
}
