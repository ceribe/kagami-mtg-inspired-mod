using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons
{
	public class Bloody_Tome : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bloody Tome");
            Tooltip.SetDefault("It feeds on your energy");
		}

		public override void SetDefaults()
		{
            item.damage = 1;
            item.autoReuse = true;
            item.rare = 2;
            item.mana = 0;
            item.UseSound = SoundID.Item8;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 26;
            item.useTime = 30;
            item.width = 24;
            item.height = 28;
            item.shoot = 270;
            item.shootSpeed = 5f;
            item.knockBack = 3.5f;
            item.magic = true;
            item.value = 1000;
        }

        public override void UpdateInventory(Player player)
        {
            item.damage = player.statLife;
            item.mana = player.statLife/50;
            if (player.statLife >= 200) item.useTime = 60;
            if (player.statLife >= 300) item.useTime = 30;
            if (player.statLife >= 400) item.useTime = 15;
            item.shootSpeed = 4f + player.statLife / 100f;
        }

        public override void HoldItem(Player player)
        {
            player.AddBuff(mod.BuffType("Curse_of_The_Bloody_Tome"), 2);

        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddIngredient(null,"Blood", 2);
            recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
