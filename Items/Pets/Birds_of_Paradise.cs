using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Pets
{
	public class Birds_of_Paradise : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Birds of Paradise");
			Tooltip.SetDefault("Summons Birds of Paradise to follow aimlessly behind you");
		}

		public override void SetDefaults()
		{
            item.damage = 0;
            item.useStyle = 1;
            item.shoot = 380;
            item.width = 16;
            item.height = 30;
            item.UseSound = SoundID.Item2;
            item.useAnimation = 20;
            item.useTime = 20;
            item.rare = 2;
            item.noMelee = true;
            item.value = 15*2000;
            item.shoot = mod.ProjectileType("Birds_of_Paradise");
			item.buffType = mod.BuffType("Birds_of_Paradise_Pet");
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bird, 1);
            recipe.AddIngredient(ItemID.PurpleDye, 5);
            recipe.AddIngredient(ItemID.YellowDye, 5);
            recipe.AddIngredient(ItemID.OrangeDye, 5);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}