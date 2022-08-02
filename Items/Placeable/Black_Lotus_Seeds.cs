using Terraria.ModLoader;

namespace KagamiMod.Items.Placeable
{
	public class Black_Lotus_Seeds : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Lotus Seeds");
        }
        public override void SetDefaults()
		{
			item.autoReuse = true;
			item.useTurn = true;
			item.useStyle = 1;
			item.useAnimation = 15;
			item.useTime = 10;
			item.maxStack = 99;
			item.consumable = true;
			item.placeStyle = 0;
			item.width = 12;
			item.height = 14;
			item.value = 50000;
			//item.createTile = mod.TileType<Tiles.Black_Lotus_Herb>();
            item.createTile = mod.TileType("Black_Lotus_Herb");
        }
	}
}