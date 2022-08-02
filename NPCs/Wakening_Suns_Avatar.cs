using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
    public class Wakening_Suns_Avatar : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wakening Sun's Avatar");
            Main.npcFrameCount[npc.type] = 16;
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 40;
            npc.scale = 3f;
            npc.damage = 70;
            npc.defense = 60;
            npc.lifeMax = 5000;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 50000f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 3;
            aiType = NPCID.WalkingAntlion;
            animationType = NPCID.WalkingAntlion;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return (spawnInfo.player.ZoneDesert && Main.hardMode && NPC.downedMoonlord && Main.dayTime) ? 0.02f : 0f;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), mod.ItemType("Sun_Droplet"), Main.rand.Next(3, 6));
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

            npc.ai[1]++;
            if (npc.ai[1]==120)
            {
                shootAtPlayer(50f, npc.damage, 467, P, false);
                npc.ai[1] = 0;
            }
        }
    }
}