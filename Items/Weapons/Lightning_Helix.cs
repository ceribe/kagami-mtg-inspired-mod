using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons
{
    public class Lightning_Helix : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lightning Helix");
            Tooltip.SetDefault("Shooting helixes heals you");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.autoReuse = true;
            item.rare = 4;
            item.mana = 20;
            item.noMelee = true;
            item.useStyle = 5;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 24;
            item.height = 28;
            item.knockBack = 1.5f;
            item.magic = true;
            item.value = 51000;
            item.shootSpeed = 10f;
            //item.shoot = mod.ProjectileType("Lightning_Helix");
            item.shoot = 389;


        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(null, "Boros_Certificate", 2);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            player.statLife += 1;
            player.HealEffect(1, true);
            return true;
        }
    }
}
