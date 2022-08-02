using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Accesories
{
	public class Caged_Sun : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Caged Sun");
            Tooltip.SetDefault("Day stops to exist\nMax mana is doubled (Caps at 400)");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 2));
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 50000;
			item.rare = 20;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
            {
                Main.dayTime = false;
                if(Main.time==Main.nightLength-1) Main.time = 0;
                player.statManaMax2 *= 2;
                Lighting.AddLight((int)((double)player.position.X + (double)(player.width / 2)) / 16, (int)((double)player.position.Y + (double)(player.height / 2)) / 16, 10f, 10f, 10f);

            }
		}

        public override void GrabRange(Player player, ref int grabRange)
        {
            grabRange *= 3;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Terrarium, 1);
            recipe.AddIngredient(null, "Sun_Droplet", 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}