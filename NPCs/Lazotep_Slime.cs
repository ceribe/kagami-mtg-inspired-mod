using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Lazotep_Slime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lazotep Slime");
            Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 18;
            npc.scale = 2f;
			npc.damage = 30;
			npc.defense = 100;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 6000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode && NPC.downedGolemBoss) return SpawnCondition.OverworldDaySlime.Chance * 0.02f;
            else return 0f;
        }

        public virtual void HitEffect(int hitDirection, double damage)
        {
            for (int d = 0; d <= damage*10; d++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, 41, 0f, 0f, 150, default(Color), 1.5f);
            }
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Lazotep_Crystal"), Main.rand.Next(3, 6));

        }

        public override bool? CanBeHitByProjectile(Projectile projectile)
        {
            return !projectile.magic;
        }

    }
}
