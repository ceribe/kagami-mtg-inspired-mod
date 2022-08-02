using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Bags
{
	public class Orzhova_Syndicate_Bundle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orzhova Sydicate Bundle");
			Tooltip.SetDefault("Contains items related to the Orzhov guild\nRight click to open");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
            item.maxStack = 9999;
            item.rare = 3;
            item.consumable = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

        public override void RightClick(Player player)
        {
            int r = Main.rand.Next(0, 6);
            switch (r)
            {
                case 0: player.QuickSpawnItem(mod.ItemType("Gift_of_Orzhova"), 1); break;
                case 1: case 2: player.QuickSpawnItem(mod.ItemType("Orzhov_Certificate"), 1); break;
                case 3: case 4: case 5: player.QuickSpawnItem(mod.ItemType("Obzedats_Potion"), Main.rand.Next(1, 5)); break;
            }
		}

	}
}