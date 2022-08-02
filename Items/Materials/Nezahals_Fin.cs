using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Materials
{
	public class Nezahals_Fin : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Nezahal's Fin");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 9999;
            item.value = 5000;
            item.rare = 2;
        }
	}
}
