using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Gruul_Certificate: ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Gruul Certificate");
            Tooltip.SetDefault("Used to craft Gruul related items");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 1000;
            item.rare = 2;
        }
	}
}
