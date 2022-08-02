using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Wheel_of_Sun_and_Moon : ModItem
	{
        public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Wheel of Sun and Moon");
            Tooltip.SetDefault("LMB: Alternates day & night");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 30000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item25;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            if (Main.dayTime)
            {
                Main.dayTime = false;
                Main.time = 0.0;
            }
            else
            {
                Main.dayTime = true;
                Main.time = 0.0;
            }
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(null,"Moonglove", 2);
            recipe.AddIngredient(null, "Dawnglove", 2);
            recipe.AddIngredient(ItemID.HallowedBar, 5);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}
