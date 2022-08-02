using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace KagamiMod
{
    // ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
    // several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
    public class KagamiPlayer : ModPlayer
    {
        public int UsedSunDroplets = 0;
        public int UsedBeacon = 0;
        public bool Critted = false;
        public bool DSed = false;
        public short storm = 1;
        public bool birdsPet = false;
        public bool blob = false;
        public int Mutation = 0;

        public override void ResetEffects()
        {
            player.statLifeMax2 += UsedSunDroplets;
            if (UsedBeacon == 1) player.statLifeMax2 *= 2;
            if (!player.HasBuff(mod.BuffType("Critical_Valor"))) Critted = false;
            if (!player.HasBuff(mod.BuffType("Double_Strike"))) DSed = false;
            birdsPet = false;
            blob = false;
            switch (Mutation)
            {
                case 0:break;
                case 1: player.AddBuff(mod.BuffType("Mutation_Wings"), 2);break;
                case 2: player.AddBuff(mod.BuffType("Mutation_Scales"), 2);break;
                case 3: player.AddBuff(mod.BuffType("Mutation_Brain"), 2);break;
                case 4: player.AddBuff(mod.BuffType("Mutation_Muscles"), 2); break;
                case 5: player.AddBuff(mod.BuffType("Mutation_Claws"), 2); break;
                case 6: player.AddBuff(mod.BuffType("Mutation_Legs"), 2); break;
                case 7: player.AddBuff(mod.BuffType("Mutation_Horns"), 2); break;
                case 8: player.AddBuff(mod.BuffType("Mutation_Tentacles"), 2); break;
                case 9: player.AddBuff(mod.BuffType("Mutation_Gills"), 2); break;
                case 10: player.AddBuff(mod.BuffType("Mutation_Fins"), 2); break;
                case 11: player.AddBuff(mod.BuffType("Mutation_Webbed_Foot"), 2); break;
                case 12: player.AddBuff(mod.BuffType("Mutation_Tail"), 2); break;
                case 13: player.AddBuff(mod.BuffType("Mutation_Photophore"), 2); break;
                case 14: player.AddBuff(mod.BuffType("Mutation_Eyes"), 2); break;
                case 15: player.AddBuff(mod.BuffType("Mutation_Spikes"), 2); break;

            }

        }
        //
        public override void clientClone(ModPlayer clientClone)
        {
            KagamiPlayer clone = clientClone as KagamiPlayer;
            // Here we would make a backup clone of values that are only correct on the local players Player instance.
            // Some examples would be RPG stats from a GUI, Hotkey states, and Extra Item Slots
            // clone.someLocalVariable = someLocalVariable;
        }

        public override void SyncPlayer(int toWho, int fromWho, bool newPlayer)
        {
            ModPacket packet = mod.GetPacket();
            packet.Write((byte)KagamiModMessageType.UsedBeacon);
            packet.Write((byte)KagamiModMessageType.UsedSunDroplets);
            packet.Write((byte)KagamiModMessageType.Mutation);
            packet.Write((byte)player.whoAmI);
            packet.Write(UsedBeacon);
            packet.Write(UsedSunDroplets);
            packet.Write(Mutation);
            packet.Send(toWho, fromWho);
        }

        public override void SendClientChanges(ModPlayer clientPlayer)
        {
            // Here we would sync something like an RPG stat whenever the player changes it.
            // So far, ExampleMod has nothing that needs this.
            // if (clientPlayer.someLocalVariable != someLocalVariable)
            // {
            //    Send a Mod Packet with the changes.
            // }
        }

        public override TagCompound Save()
        {
            return new TagCompound {
				// {"somethingelse", somethingelse}, // To save more data, add additional lines
                {"UsedBeacon", UsedBeacon},
                {"UsedSunDroplets", UsedSunDroplets},
                {"Mutation", Mutation},
            };
            //note that C# 6.0 supports indexer initializers
            //return new TagCompound {
            //	["score"] = score
            //};
        }

        public override void Load(TagCompound tag)
        {
            UsedBeacon = tag.GetInt("UsedBeacon");
            UsedSunDroplets = tag.GetInt("UsedSunDroplets");
            Mutation = tag.GetInt("Mutation");
        }

        public override void LoadLegacy(BinaryReader reader)
        {
            int loadVersion = reader.ReadInt32();
            //score = reader.ReadInt32();
        }

        public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("Hard_Mode"));
            item.stack = 1;
            items.Add(item);
        }

        public override void ModifyHitNPC(Item item, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            if (player.HasBuff(mod.BuffType("Critical_Valor")))
            {
                Critted = true;
            }
            if (player.HasBuff(mod.BuffType("Double_Strike")))
            {
                damage *= 2;
                DSed = true;
            }
        }

        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (player.HasBuff(mod.BuffType("Critical_Valor")))
            {
                Critted = true;
            }
            if (player.HasBuff(mod.BuffType("Double_Strike")))
            {
                damage *= 2;
                DSed = true;
            }
        }

        public override bool CanBeHitByProjectile(Projectile proj)
        {
            return player.HasBuff(mod.BuffType("Hexproof")) ? false : true;
        }

        public override void UpdateDead()
        {
            storm = 1;
        }
    }
}
