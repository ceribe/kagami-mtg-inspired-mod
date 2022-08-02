using Terraria.ModLoader;
using Terraria.ID;

namespace KagamiMod.Items.Placeable
{
	public class Growth_Spiral : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Growth Spiral");
            Tooltip.SetDefault("Unlimited acorns");

        }
        public override void SetDefaults()
		{
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = false;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 1000;
            item.createTile = TileID.Saplings;
        }
	}
}