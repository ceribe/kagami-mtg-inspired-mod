using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Blood : ModItem
	{
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 50;
            item.rare = 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Still_Beating_Heart", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this,100);
            recipe.AddRecipe();
        }
    }
}
