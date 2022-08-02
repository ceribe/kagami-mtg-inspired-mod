using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Dawnglove : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Dawnglove");
            Tooltip.SetDefault("Moonglove's daytime counterpart");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 200;
            item.rare = 4;
        }
	}
}
