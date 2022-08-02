using Terraria.ModLoader;

namespace KagamiMod.Items.Placeable
{
	public class Lazotep_Wall : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Lazotep Wall");
            Tooltip.SetDefault("Wall made of lazotep.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 9999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = mod.WallType("Lazotep_Wall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Lazotep_Dust");
			recipe.SetResult(this, 20);
			recipe.AddRecipe();
		}
	}
}