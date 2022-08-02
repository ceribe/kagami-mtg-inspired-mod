using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Health_Converter : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Converter");
            Tooltip.SetDefault("50 Life -> 200 Mana");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 50000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            if (player.statLife > 50)
            {
                player.ManaEffect(200);
                player.statLife -=50;
                player.statMana += 200;
                return true;
            }
            return false;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LifeCrystal, 10);
            recipe.AddIngredient(ItemID.SuperManaPotion, 20);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
