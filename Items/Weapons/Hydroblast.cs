using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;

namespace KagamiMod.Items.Weapons
{
	public class Hydroblast : ModItem
	{

        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hydroblast");
            Tooltip.SetDefault("Super effective in the Underworld");
        }

		public override void SetDefaults()
		{
            item.autoReuse = true;
            item.rare = 2;
            item.mana = 10;
            item.UseSound = SoundID.Item21;
            item.noMelee = true;
            item.useStyle = 5;
            item.damage = 19;
            item.useAnimation = 17;
            item.useTime = 17;
            item.width = 24;
            item.height = 28;
            item.shoot = 27;
            item.scale = 0.9f;
            item.shootSpeed = 4.5f;
            item.knockBack = 5f;
            item.magic = true;
            item.value = 5000;
        }
        public override void UpdateInventory(Player player)
        {
            if (player.ZoneUnderworldHeight) item.damage = 30;
            else SetDefaults();
        }
    }
}
