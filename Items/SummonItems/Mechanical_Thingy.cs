using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.SummonItems
{
	public class Mechanical_Thingy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechanical Thingy");
			Tooltip.SetDefault("Summons the mechanical trio");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 500;
			item.rare = 4;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && Main.hardMode && !NPC.AnyNPCs(NPCID.SkeletronPrime) && !NPC.AnyNPCs(NPCID.Retinazer) && !NPC.AnyNPCs(NPCID.Spazmatism) && !NPC.AnyNPCs(NPCID.TheDestroyer);
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.TheDestroyer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.SkeletronPrime);
            Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalWorm);
            recipe.AddIngredient(ItemID.MechanicalSkull);
            recipe.AddIngredient(ItemID.MechanicalEye);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}