using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.SummonItems
{
	public class Dino_Bait : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dino Bait");
			Tooltip.SetDefault("Summons Nezahal, Primal Tide");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 9999;
			item.rare = 1;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}

        public override bool CanUseItem(Player player)
        {
            // "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
            return player.ZoneBeach && !NPC.AnyNPCs(mod.NPCType("Nezahal")) && !Main.dayTime;
        }

        public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Nezahal"));
            Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel);
            recipe.AddIngredient(ItemID.Worm,1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this, 1);
            recipe.AddRecipe();
		}
	}
}