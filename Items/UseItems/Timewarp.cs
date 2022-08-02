using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class   Timewarp : ModItem
	{
        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Time Warp (version 1)");
            Tooltip.SetDefault("LMB: Warp to Nighttime\nRMB: Warp to Daytime");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 24000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item25;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {

                Main.dayTime = true;
                Main.time = 0.0;
            }
            else
            {
                Main.dayTime = false;
                Main.time = 0.0;
            }
            return true;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ItemID.SoulofNight, 20);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(null, "Time_Distortion", 1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
			recipe.AddRecipe();

        }
	}
}
