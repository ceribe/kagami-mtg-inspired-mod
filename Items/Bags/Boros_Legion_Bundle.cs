using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Bags
{
	public class Boros_Legion_Bundle : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boros Legion Bundle");
			Tooltip.SetDefault("Contains items related to the Boros guild\nRight click to open");
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
                case 0: player.QuickSpawnItem(mod.ItemType("Assemble_the_Legion"), 1); break;
                case 1: case 2:  player.QuickSpawnItem(mod.ItemType("Boros_Certificate"), 1); break;
                case 3:  case 4: case 5: player.QuickSpawnItem(mod.ItemType("Arrow_of_Justice"), Main.rand.Next(100,301)); break;
            }
            if(Main.rand.Next(0, 50)==1)
            {
                player.QuickSpawnItem(mod.ItemType("Sword_of_War"), 1);
            }
            if (Main.rand.Next(0, 50) == 1)
            {
                player.QuickSpawnItem(mod.ItemType("Sword_of_Peace"), 1);
            }
        }

	}
}