using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons
{
    public class Lazotep_Yoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lazotep Yoyo");
            Tooltip.SetDefault("Shoots tiles ignoring yoyo");  //The (English) text shown below your weapon's name
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 3));
        }

        public override void SetDefaults()
        {
            item.damage = 100;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 24;            //Weapon's texture's width
            item.height = 24;           //Weapon's texture's height
            item.useTime = 25;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 25;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 5;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 1f;         //The force of knockback of the weapon. Maximum is 20
            item.value = 50000;          //The value of the weapon
            item.rare = 7;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.shoot = mod.ProjectileType("Lazotep_Yoyo");
            item.shootSpeed = 20f;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.channel = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Lazotep_Crystal", 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
