using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.UseItems.Dev
{
	public class Expert_Manipulator : ModItem
	{
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Expert Manipulator");
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
            if (Main.expertMode)
            {
                Main.expertMode = false;
                Main.NewText("Expertmode is not active", 200, 10, 200);
            }
            else
            {
                Main.expertMode = true;
                Main.NewText("Expertmode is active", 200, 10, 200);
            }

            return true;
        }

	}
}
