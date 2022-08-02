using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
    public class Biogenic_Ooze : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Biogenic Ooze");
            Main.npcFrameCount[npc.type] = 2;
        }

        public override void SetDefaults()
        {
            npc.width = 24;
            npc.height = 18;
            npc.scale = 2f;
            npc.damage = 10;
            npc.defense = 10;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 1000f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }


        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("Simic_Combine_Bundle"), 1);

        }
        public override void AI()
        {
            npc.ai[1]++;
            if(npc.ai[1]%300==1)
            {
                NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, mod.NPCType("Biogenic_Ooze_Spawn"));
                npc.ai[1] = 0;

            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (spawnInfo.player.ZoneJungle && NPC.downedQueenBee) ? 0.025f : 0f;
        }
    }
}
