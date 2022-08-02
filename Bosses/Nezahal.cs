using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.Bosses
{
    [AutoloadBossHead]
    public class Nezahal : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nezahal, Primal Tide");
            Main.npcFrameCount[npc.type] = 4;
		}
        private bool[] doneNova = { false, false, false };
        public override void SetDefaults()
		{
			npc.width = 90;
            npc.boss = true;
            npc.noGravity = true;
			npc.height = 24;
            npc.scale = 5f;
			npc.damage = 10;
			npc.defense = 10;
			npc.lifeMax = 2000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 6000f;
            npc.noTileCollide = true;
            npc.knockBackResist = 0.1f;
			npc.aiStyle = 5;
            aiType = NPCID.FlyingSnake;
			animationType = NPCID.FlyingSnake;
            music = MusicID.Boss2;
            npc.netAlways = true;
            musicPriority = MusicPriority.BossMedium;
            bossBag = mod.ItemType("NezahalBag");
        }
        
        public override void NPCLoot()
        {
            if (Main.expertMode)
            {
                npc.DropBossBags();
                doFrostNova(5f, 30, 50);
            }
            else
            {
                int choice = Main.rand.Next(0, 3);
                if (choice == 0)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Nezahals_Heart"));
                }
                else if (choice == 1)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Mystic_Remora"));
                }
                else if (choice == 2)
                {
                    Item.NewItem(npc.getRect(), mod.ItemType("Hydroblast"));
                }
                Item.NewItem(npc.getRect(), mod.ItemType("Nezahals_Fin"), Main.rand.Next(1, 5));
            }
            if (!KagamiWorld.downedNezahal)
            {
                KagamiWorld.downedNezahal = true;
                if (Main.netMode == NetmodeID.Server)
                    NetMessage.SendData(MessageID.WorldData);
            }
        }

        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = ItemID.LesserManaPotion;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.75f * bossLifeScale);  //boss life scale in expertmode
            npc.damage = (int)(npc.damage * 0.6f);  //boss damage increase in expermode
        }

        void doFrostNova(float Speed,int damage, float numberProjectiles)
        {
            float rotation = MathHelper.ToRadians(180);
            short type = (short)mod.ProjectileType("Nezahal_Projectile");
            Main.PlaySound(SoundID.Roar, (int)npc.position.X, (int)npc.position.Y, 0);
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(Speed, Speed).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(vector8.X, vector8.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, 2f, 0);
            }
        }

        void shootAtPlayer(float Speed, int damage, int type, Player P,bool sound=true)
        {
            Vector2 vector8 = new Vector2(npc.position.X + (npc.width / 2), npc.position.Y + (npc.height / 2));
            if(sound) Main.PlaySound(23, (int)npc.position.X, (int)npc.position.Y, 17);
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

            //Enrage mechanic
            if (!Main.player[npc.target].ZoneBeach)
            {
                shootAtPlayer(50f, 100, ProjectileID.IcewaterSpit, P,false);
                if (npc.ai[0] % 60 == 1)
                    Main.PlaySound(SoundID.Roar, npc.position, 0);
            }

            if (Main.expertMode)
            {
                npc.ai[1]++;
                if (npc.ai[1] % 100 == 0)
                {
                    shootAtPlayer(5f, npc.damage, (short)mod.ProjectileType("Nezahal_Projectile"), P);
                    npc.ai[1] = 0;
                }

                if (npc.ai[1] % 10 == 0 && npc.life < npc.lifeMax / 2)
                {
                    shootAtPlayer(5f, npc.damage, ProjectileID.IcewaterSpit, P);
                }

                if (!doneNova[0] && npc.life <= npc.lifeMax - 1000)
                {
                    doFrostNova(2f, 30, 20);
                    doneNova[0] = true;
                }

                if (!doneNova[2] && npc.life <= npc.lifeMax - 2000)
                {
                    doFrostNova(3f, 30, 30);
                    doneNova[2] = true;
                }

                if (!doneNova[1] && npc.life <= 200)
                {
                    doFrostNova(4f, 30, 40);
                    doneNova[1] = true;
                }
            }
            else
            {
                npc.ai[1]++;
                if (npc.ai[1]%100 == 0)
                {
                    shootAtPlayer(5f, npc.damage, (short)mod.ProjectileType("Nezahal_Projectile"), P);
                    npc.ai[1] = 0;
                }

                if (npc.ai[1]%10 == 0 && npc.life < npc.lifeMax / 4)
                {
                    shootAtPlayer(5f, npc.damage, ProjectileID.IcewaterSpit, P);
                }

                if (!doneNova[0] && npc.life <= npc.lifeMax - 1000)
                {
                    doFrostNova(2f, 30, 20);
                    doneNova[0] = true;
                }

                if (!doneNova[1] && npc.life <= 200)
                {
                    doFrostNova(3f, 30, 30);
                    doneNova[1] = true;
                }
            }
            //if(npc.ai[0]%600==1)
            //{
            //    NPC.NewNPC((int)npc.position.X, (int)npc.position.Y, NPCID.Shark);
            //}

        }

    }
}
