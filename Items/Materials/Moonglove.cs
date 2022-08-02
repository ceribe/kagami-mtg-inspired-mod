using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Moonglove : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Moonglove");
            Tooltip.SetDefault("\"Concentrated, a drop will kill a giant.\"");
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
