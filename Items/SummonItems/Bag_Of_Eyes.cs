using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Items.SummonItems
{
	public class Bag_Of_Eyes : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bag of Eyes");
			Tooltip.SetDefault("Summons too many eyes");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 9999;
			item.value = 100;
			item.rare = 4;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}

		public override bool CanUseItem(Player player)
		{
			return !Main.dayTime && Main.hardMode && !NPC.AnyNPCs(NPCID.Retinazer) && !NPC.AnyNPCs(NPCID.Spazmatism);
		}

		public override bool UseItem(Player player)
		{
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);

            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);

            Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SuspiciousLookingEye,5);
            recipe.AddIngredient(ItemID.MechanicalEye,5);
            recipe.AddIngredient(ItemID.Lens, 10);
            recipe.AddIngredient(ItemID.Leather, 10);
            recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}