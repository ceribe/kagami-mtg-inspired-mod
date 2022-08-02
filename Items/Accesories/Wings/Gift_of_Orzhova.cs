using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
namespace KagamiMod.Items.Accesories.Wings
{
    [AutoloadEquip(EquipType.Wings)]
    public class Gift_of_Orzhova : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gift of Orzhova");
            Tooltip.SetDefault("\"Remember by whose gift you ascend\"\nUsable in hardmode\nIncrese life regen by 10%\nAllows flight and slow fall\nHorizontal speed: 6\nAcceleration multiplier: 1\nFlight time: 90");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 5000;
            item.rare = 3;
            item.accessory = true;
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (Main.hardMode)
            {
                player.wingTimeMax = 90;
                player.lifeRegen = (int)(player.lifeRegen*1.1f);
                if (player.wingTime < player.wingTimeMax)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Dust.NewDust(player.position, player.width, player.height, 59, 0f, 0f, 150, default(Color), 1.5f); //blue
                        Dust.NewDust(player.position, player.width, player.height, 64, 0f, 0f, 150, default(Color), 1.5f); //yellow
                        Dust.NewDust(player.position, player.width, player.height, 62, 0f, 0f, 150, default(Color), 1.5f); //purple
                    }
                }
            }
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
            speed = 6f;
            acceleration *= 1f;
        }

    }
}