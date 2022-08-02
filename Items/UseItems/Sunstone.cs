using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Sunstone : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sunstone");
            Tooltip.SetDefault("Stops the rain");
		}
		public override void SetDefaults()
		{
            item.rare = 10;
            item.width = 24;
            item.height = 28;
            item.value = 25000;
            item.maxStack = 1;
            item.useAnimation = 30;
            item.UseSound = SoundID.Item4;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            Main.raining = false;
            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Sun_Droplet", 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
