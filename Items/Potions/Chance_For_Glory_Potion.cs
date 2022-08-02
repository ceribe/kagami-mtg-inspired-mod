using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Potions
{
    public class Chance_For_Glory_Potion : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chance for Glory Potion");
            Tooltip.SetDefault("Provides 10s indestructability, then you most likely die");
        }
        public override void SetDefaults()
        {
            item.rare = 3;
            item.width = 24;
            item.height = 28;
            item.value = 333;
            item.maxStack = 9999;
            item.UseSound = SoundID.Item3;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useStyle = 3;
            item.consumable = true;
            item.buffType = mod.BuffType("Indestructability");
            item.buffTime = 60 * 10;
        }
        public override bool UseItem(Player player)
        {
            player.statLife = 1;
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 3);
            recipe.AddIngredient(null, "Boros_Certificate", 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
