using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Dawnglove : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dawnglove");
            Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 32;
            npc.scale = 1f;
			npc.damage = 10;
			npc.defense = 20;
			npc.lifeMax = 1000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath32;
            npc.value = 100f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 14;
			aiType = NPCID.JungleBat;
			animationType = NPCID.DemonEye;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return Main.hardMode ? SpawnCondition.OverworldDay.Chance * 0.02f : 0f;
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Dawnglove"), 1);
        }
	}
}
