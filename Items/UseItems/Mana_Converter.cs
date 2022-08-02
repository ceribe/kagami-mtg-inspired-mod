using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Mana_Converter : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana Converter");
            Tooltip.SetDefault("Mana -> Life");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 50000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            int missingHP = Main.player[Main.myPlayer].statLifeMax2 - Main.player[Main.myPlayer].statLife;
            int healed;
            if (missingHP > Main.player[Main.myPlayer].statMana) healed = Main.player[Main.myPlayer].statMana;
            else healed = missingHP;
            if (Main.myPlayer == player.whoAmI)
            {
                player.HealEffect(healed, true);
                player.statLife += healed;
                player.statMana -= healed;
            }
            return true;
        }


        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuperHealingPotion, 10);
            recipe.AddIngredient(ItemID.ManaCrystal, 10);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
