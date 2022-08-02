using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Boros_Mastiff : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Boros Mastiff");
            Main.npcFrameCount[npc.type] = 11;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 18;
            npc.scale = 0.8f;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 100;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 400f;
			npc.knockBackResist = 0.3f;
			npc.aiStyle = 3;
			aiType = NPCID.DesertBeast;
			animationType = NPCID.DesertBeast;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.025f;
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Boros_Legion_Bundle"), 1);

        }
    }
}
