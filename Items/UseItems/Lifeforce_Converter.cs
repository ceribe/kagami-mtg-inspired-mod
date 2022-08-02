using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems
{
	public class Lifeforce_Converter : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lifeforce Converter");
            Tooltip.SetDefault("LMB: Mana -> Life\nRMB: 50 Life -> 200 Mana");
		}
		public override void SetDefaults()
		{
            item.rare = 5;
            item.width = 24;
            item.height = 28;
            item.value = 100000;
            item.maxStack = 1;
            item.UseSound = SoundID.Item4;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                if (player.statLife > 50)
                {
                    player.ManaEffect(200);
                    player.statLife -= 50;
                    player.statMana += 200;
                }
                else return false;
            }
            else
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
            }
            return true;
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null,"Health_Converter", 1);
            recipe.AddIngredient(null,"Mana_Converter", 1);

            recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
