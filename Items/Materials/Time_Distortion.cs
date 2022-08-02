using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Time_Distortion : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Time Distortion");
            Tooltip.SetDefault("Dropped by King Slime during the certain time of the day");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 10000;
            item.rare = 4;
        }
    }
}
