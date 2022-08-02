using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace KagamiMod.Items.Accesories.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class Cobbled_Wings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cobbled Wings");
            Tooltip.SetDefault("Allows flight and slow fall\nHorizontal speed: 4\nAcceleration multiplier: 1\nFlight time: 20");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 50;
            item.rare = 1;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
          player.wingTimeMax = 20;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
            ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.85f;
            ascentWhenRising = 0.15f;
            maxCanAscendMultiplier = 1f;
            maxAscentMultiplier = 1.5f;
            constantAscend = 0.135f;
        }

        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 4f;
            acceleration *= 1f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Leather, 5);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}