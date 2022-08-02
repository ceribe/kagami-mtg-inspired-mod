using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Weapons.MinorLegendary
{
    public class Sword_of_Peace : ModItem
    {
        private short counter = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword of Peace");
            Tooltip.SetDefault("Minor Legendary Sword\nLMB unlocked with Hardmode\n\"The most peaceful of swords.\"");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 1;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 48;            //Weapon's texture's width
            item.height = 52;           //Weapon's texture's height
            item.useTime = 30;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 30;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 6;         //The force of knockback of the weapon. Maximum is 20
            item.value = 100000;          //The value of the weapon
            item.rare = 5;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
            item.shoot = 503;
            item.scale = 2f;
            item.shootSpeed = 30f;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode;
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.Next(3) == 0)
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
            }
        }



        public override void HoldItem(Player player)
        {
            SetDefaults();
            counter++;
            if (counter==120)
            {
                int heal = Main.rand.Next(1, 6);
                player.statLife += heal;
                player.HealEffect(heal, true);
                counter = 0;
            }
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            damage = 100;
            return true;
        }
    }
}
