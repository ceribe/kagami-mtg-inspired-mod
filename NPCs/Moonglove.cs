using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Moonglove : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moonglove");
            Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 30;
			npc.height = 32;
            npc.scale = 1f;
			npc.damage = 100;
			npc.defense = 20;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath32;
            npc.value = 100f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 2;
			aiType = NPCID.DemonEye;
			animationType = NPCID.DemonEye;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return Main.hardMode ? SpawnCondition.OverworldNightMonster.Chance * 0.02f : 0f;
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Moonglove"), 1);
        }
	}
}
