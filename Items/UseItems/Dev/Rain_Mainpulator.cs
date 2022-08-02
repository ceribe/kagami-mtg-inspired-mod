using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems.Dev
{
	public class Rain_Mainpulator : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rain Manipulator");
            Tooltip.SetDefault("UNOBTAINABLE\nITEM FOR TESTING");
		}
		public override void SetDefaults()
		{
            item.rare = -11;
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.maxStack = 1;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = false;

        }

        public override bool UseItem(Player player)
        {
            if (Main.raining)
            {
                Main.raining = false;
                Main.NewText("Rain is not active", 200, 10, 200);
            }
            else
            {
                Main.raining = true;
                Main.NewText("Rain is active", 200, 10, 200);
            }

            return true;
        }

	}
}
