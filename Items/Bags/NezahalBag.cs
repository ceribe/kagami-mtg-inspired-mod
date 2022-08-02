using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.Bags
{
	public class NezahalBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 1;
			item.expert = true;
			bossBagNPC = mod.NPCType("Nezahal");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			int choice = Main.rand.Next(0,3);
			if (choice == 0)
			{
                player.QuickSpawnItem(mod.ItemType("Nezahals_Heart"));
            }
			else if (choice == 1)
			{
                player.QuickSpawnItem(mod.ItemType("Mystic_Remora"));
			}
            else if (choice == 2)
            {
                player.QuickSpawnItem(mod.ItemType("Hydroblast"));
            }
            player.QuickSpawnItem(mod.ItemType("Nezahals_Fin"), Main.rand.Next(1,5));
            player.QuickSpawnItem(mod.ItemType("High_Tide_Potion"), Main.rand.Next(3, 5));
        }
	}
}