using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons
{
	public class Nezashark : ModItem
	{

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nezashark");
            Tooltip.SetDefault("66% chance to not consume ammo\n\'Megashark's older brother\'");
		}

		public override void SetDefaults()
		{
            item.CloneDefaults(ItemID.Megashark);
            item.value = 160000;
            item.rare = 6;
            item.damage = 30;
            item.useTime = 5;
            item.shootSpeed = 12;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .66f;
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-10, 0);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Nezahals_Fin", 20);
            recipe.AddIngredient(null, "Lazotep_Dust", 25);
            recipe.AddIngredient(ItemID.Megashark, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
