using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems.Mutations
{
	class Mutation_Brain : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Mutation: Brain");
            Tooltip.SetDefault("Permamently increase max mana by 20 and mana regen slightly\nRemoves all other mutations on use");
        }

		public override void SetDefaults()
		{
            item.noUseGraphic = true;
            item.rare = 3;
            item.width = 16;
            item.height = 12;
            item.value = 1000;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item108;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

		public override bool UseItem(Player player)
		{
            player.GetModPlayer<KagamiPlayer>().Mutation = 3;
			return true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "Simic_Certificate", 1);
            recipe.AddTile(TileID.Chairs);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
