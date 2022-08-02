using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace KagamiMod.NPCs
{
    public class Biogenic_Ooze_Spawn : ModNPC
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
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 50f;
            npc.knockBackResist = 0.5f;
            npc.aiStyle = 1;
            aiType = NPCID.BlueSlime;
            animationType = NPCID.BlueSlime;
        }
    }
}
