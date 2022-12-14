using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons
{
    public class Sunforger : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sunforger");
            Tooltip.SetDefault("Shoots a random projectile");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 20;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 32;            //Weapon's texture's width
            item.height = 32;           //Weapon's texture's height
            item.useTime = 30;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 30;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 6;         //The force of knockback of the weapon. Maximum is 20
            item.value = 1000;          //The value of the weapon
            item.rare = 3;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.shoot = 1;
            item.scale = 2f;
            item.shootSpeed = 30f;
        }


        public override void HoldItem(Player player)
        {
            item.shoot = Main.rand.Next(1, 712);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronHammer, 1);
            recipe.AddIngredient(null, "Boros_Certificate", 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
