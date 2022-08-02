using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Basillica_Screecher : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Basillica Screecher");
            Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 18;
            npc.scale = 1.5f;
			npc.damage = 50;
			npc.defense = 10;
			npc.lifeMax = 300;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
            npc.value = 500f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Underground.Chance * 0.25f;
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Orzhova_Syndicate_Bundle"), 1);
        }
	}
}
