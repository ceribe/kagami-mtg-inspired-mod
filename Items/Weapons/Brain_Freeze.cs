using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons
{
    public class Brain_Freeze : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brain Freeze");
            Tooltip.SetDefault("Each use is more powerful");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
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
            item.shootSpeed = 20f;
            item.shoot = mod.ProjectileType("Brain_Freeze");

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ItemID.FrostCore, 5);
            recipe.AddIngredient(ItemID.IceQueenTrophy, 1);
            recipe.AddTile(TileID.Bookcases);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateInventory(Player player)
        {
            item.damage = player.GetModPlayer<KagamiPlayer>().storm;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            if (player.GetModPlayer<KagamiPlayer>().storm < 50)
            {
                player.GetModPlayer<KagamiPlayer>().storm++;
            }
            for (int i = 0; i < player.GetModPlayer<KagamiPlayer>().storm/2; i++)
            {
                Projectile.NewProjectile(position.X, position.Y, speedX + 1, speedY - i, type, damage, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX + 1, speedY + i, type, damage, knockBack, player.whoAmI);

            }
            return true;
        }
    }
}
