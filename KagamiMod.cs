using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using System;

namespace KagamiMod
{
    class KagamiMod : Mod
    {
        public KagamiMod()
        {
        }
        public class LegendaryCanUse : GlobalItem
        {
            public override bool CanUseItem(Item item, Player player)
            {
                if (item.type == mod.ItemType("Sword_of_War_and_Peace") ||
                    item.type == mod.ItemType("Star_of_Extinction") ||
                    item.type == mod.ItemType("The_Elderspell") ||
                    item.type == mod.ItemType("Sword_of_Body_and_Mind") ||
                    item.type == mod.ItemType("Sword_of_Fire_and_Ice") ||
                    item.type == mod.ItemType("Sword_of_Light_and_Shadow") ||
                    item.type == mod.ItemType("Sword_of_Feast_and_Famine") ||
                    item.type == mod.ItemType("Sword_of_Dungeons_and_Dragons"))
                {
                    bool flag = true;
                    if (player.altFunctionUse == 2)
                    {
                        if (Main.myPlayer == player.whoAmI && Main.hardMode && NPC.downedMoonlord)
                        {
                            if (Main.LocalPlayer.HasBuff(mod.BuffType("Legendary_Exhaustion"))) flag = false;
                            else player.AddBuff(mod.BuffType("Legendary_Exhaustion"), Main.expertMode ? 60 * 60 * 2 : 60 * 60);//1min in Normal mode, 2min in Expert

                        }
                    }
                    return Main.hardMode && NPC.downedMoonlord && flag;
                }
                else return true;
            }
        }

        public class LifeforceItems : GlobalItem
        {
            public override bool CanUseItem(Item item, Player player)
            {
                if (item.type == mod.ItemType("Lifeforce_Converter") ||
                    item.type == mod.ItemType("Mana_Converter") ||
                    item.type == mod.ItemType("Health_Converter"))
                {
                    bool flag = true;

                    if (Main.myPlayer == player.whoAmI && Main.hardMode)
                    {
                        if (Main.LocalPlayer.HasBuff(mod.BuffType("Spirit_Exhaustion"))) flag = false;
                        else player.AddBuff(mod.BuffType("Spirit_Exhaustion"), Main.expertMode ? 60 * 15 * 2 : 60 * 15);//15s in Normal mode, 30s in Expert

                    }
                    return flag;
                }
                else if (item.type == mod.ItemType("Boros_Charm"))
                {
                    bool flag2 = true;

                    if (Main.myPlayer == player.whoAmI && player.altFunctionUse == 2)
                    {
                        if (Main.LocalPlayer.HasBuff(mod.BuffType("Indestructability_Weariness"))) flag2 = false;
                        else
                        {
                            player.AddBuff(mod.BuffType("Indestructability_Weariness"), Main.expertMode ? 60 * 60 : 60 * 30);//30s in Normal mode, 60s in Expert
                            player.AddBuff(mod.BuffType("Indestructability"), 60 * 3);
                        }

                    }
                    return flag2;
                }
                else if (item.type == mod.ItemType("Chance_For_Glory_Potion"))
                {
                    bool flag2 = true;

                    if (Main.myPlayer == player.whoAmI && !(player.altFunctionUse == 2))
                    {
                        if (Main.LocalPlayer.HasBuff(mod.BuffType("Indestructability_Weariness"))) flag2 = false;
                        else
                        {
                            player.AddBuff(mod.BuffType("Indestructability_Weariness"), Main.expertMode ? 60 * 60 : 60 * 30);//30s in Normal mode, 60s in Expert
                        }

                    }
                    return flag2;
                }

                else if (item.type == mod.ItemType("Simic_Charm"))
                {
                    bool flag2 = true;

                    if (Main.myPlayer == player.whoAmI && player.altFunctionUse == 2)
                    {
                        if (Main.LocalPlayer.HasBuff(mod.BuffType("Hexproof_Weariness"))) flag2 = false;
                        else
                        {
                            player.AddBuff(mod.BuffType("Hexproof_Weariness"), Main.expertMode ? 60 * 60 : 60 * 30);//30s in Normal mode, 60s in Expert
                            player.AddBuff(mod.BuffType("Hexproof"), 60 * 5);
                        }

                    }
                    return flag2;
                }
                else return true;


            }
        }

        public class BloodDrops : GlobalNPC
        {
            public override void NPCLoot(NPC npc)
            {
                if (Main.bloodMoon)
                {
                    if (Main.rand.Next(0, 5) == 1)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Blood"));
                    }
                    if (Main.rand.Next(0, 500) == 1)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Still_Beating_Heart"));
                    }
                }

                if (Main.rand.Next(0, 10000) == 1)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Swords_to_Plowshares"));
                }

                if (npc.type == NPCID.LunarTowerStardust || npc.type == NPCID.LunarTowerNebula || npc.type == NPCID.LunarTowerVortex || npc.type == NPCID.LunarTowerSolar)
                {
                    if (Main.rand.Next(0, 10) == 1)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Sol_Ring"));
                    }
                }
                if (npc.type == NPCID.DarkCaster)
                {
                    if (Main.rand.Next(0, 20) == 1)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Mana_Vortex"));
                    }
                }
                if (npc.type == NPCID.Tim)
                {
                    if (Main.rand.Next(0, 2) == 1)
                    {
                        Item.NewItem(npc.getRect(), mod.ItemType("Mana_Vortex"));
                    }
                }

            }

        }

        public class BossBags : GlobalItem
        {
            public override void OpenVanillaBag(string context, Player player, int arg)
            {

                if (context == "bossBag" && arg == ItemID.KingSlimeBossBag && Main.hardMode && Main.time < 2000)
                {

                    if (Main.rand.Next(0, 2) == 1)
                    {
                        player.QuickSpawnItem(mod.ItemType("Time_Distortion"), 1);
                    }
                }

                if (context == "bossBag" && arg == ItemID.PlanteraBossBag)
                {

                    if (Main.rand.Next(0, 10) == 1)
                    {
                        player.QuickSpawnItem(mod.ItemType("Black_Lotus_Seeds"), 1);
                    }
                }


            }
        }

        public override void HandlePacket(BinaryReader reader, int whoAmI)
        {
            KagamiModMessageType msgType = (KagamiModMessageType)reader.ReadByte();
            byte playernumber = reader.ReadByte();
            switch (msgType)
            {
                case KagamiModMessageType.UsedBeacon:
                    Player BeaconPlayer = Main.player[playernumber];
                    int UsedBeacon = reader.ReadInt32();
                    BeaconPlayer.GetModPlayer<KagamiPlayer>().UsedBeacon = UsedBeacon;
                    break;
                case KagamiModMessageType.UsedSunDroplets:
                    Player SunDropletsPlayer = Main.player[playernumber];
                    int UsedSunDroplets = reader.ReadInt32();
                    SunDropletsPlayer.GetModPlayer<KagamiPlayer>().UsedSunDroplets = UsedSunDroplets;
                    break;
                case KagamiModMessageType.Mutation:
                    Player MutationPlayer = Main.player[playernumber];
                    int Mutation = reader.ReadInt32();
                    MutationPlayer.GetModPlayer<KagamiPlayer>().Mutation = Mutation;
                    break;
                default:
                    ErrorLogger.Log("KagamiMod: Unknown Message type: " + msgType);
                    break;
            }
        }
        public override void PostSetupContent()
        {
            // Showcases mod support with Boss Checklist without referencing the mod
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                bossChecklist.Call("AddBossWithInfo", "Nezahal", 1.1f, (Func<bool>)(() => KagamiWorld.downedNezahal), "Use [i:" + ItemType<Items.SummonItems.Dino_Bait>() + "] during the night at the Beach.");
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe1 = new ModRecipe(this);
            recipe1.AddIngredient(null, "Nezahals_Fin");
            recipe1.AddIngredient(ItemID.BottledWater, 5);
            recipe1.AddTile(TileID.Chairs);
            recipe1.AddTile(TileID.Bottles);
            recipe1.SetResult(ItemID.GillsPotion, 5);
            recipe1.AddRecipe();
        }

    }
        enum KagamiModMessageType : byte
        {
            UsedBeacon,
            UsedSunDroplets,
            Mutation
        }


    
}