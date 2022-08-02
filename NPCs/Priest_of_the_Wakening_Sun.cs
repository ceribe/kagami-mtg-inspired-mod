using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
	public class Priest_of_the_Wakening_Sun : ModNPC
	{
        private int timer = 0;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Priest of the Wakening Sun");
            Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
            npc.scale = 1f;
			npc.damage = 50;
			npc.defense = 40;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 5000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 8;
			aiType = NPCID.FireImp;
			animationType = NPCID.DarkCaster;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (spawnInfo.player.ZoneDesert && Main.hardMode && NPC.downedMoonlord && Main.dayTime) ? 0.05f : 0f;
        }

        public override void NPCLoot()
        {
           Item.NewItem(npc.getRect(), mod.ItemType("Sun_Droplet"), 1);
        }
        void shootAtPlayer(float Speed, int damage, int type, Player P, bool sound = true)
        {
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            if (sound) Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
            float rotation = (float)Math.Atan2(vector8.Y - (P.position.Y + (P.height * 0.5f)), vector8.X - (P.position.X + (P.width * 0.5f)));
            Projectile.NewProjectile(vector8.X, vector8.Y, (float)((Math.Cos(rotation) * Speed) * -1), (float)((Math.Sin(rotation) * Speed) * -1), type, damage, 0.5f, 0);
        }

        public override void AI()
        {
            npc.ai[0]++;
            Player P = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            timer++;
            if (timer == 120)
            {
                shootAtPlayer(50f, npc.damage, 467, P, false);
                timer = 0;
            }
        }
    }
}
