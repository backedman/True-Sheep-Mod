using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sheep.NPCs.Bosses.SpedSheep
{
    public class SpedSheep : ModNPC
    {
        private Player player;
        private float speed;
        private int countdown;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sped Sheep");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 100;
            npc.height = 75;
            npc.damage = 50; //this is now a 3 shot (from 5 shot)
            npc.defense = 20;
            npc.lifeMax = 1500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 90f;
            npc.knockBackResist = 0.4f;
            aiType = NPCID.Unicorn;
            npc.aiStyle = 26;
            animationType = 3;
            npc.npcSlots = 2f; // The higher the number, the more NPC slots this NPC takes.
            npc.boss = true; // Is a boss
            npc.lavaImmune = true; // Not hurt by lava
            npc.noGravity = false; // Not affected by gravity
            npc.noTileCollide = false; // Will not collide with the tiles. 
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss1;
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
       /* private void DespawnHandler()
        {
            if (!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if (!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                    if (npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
        } */
        private void Shoot()
        {
            int type = mod.ProjectileType("SheepLaser");
            Vector2 velocity = player.Center - npc.Center; // Get the distance between target and npc.
            float magnitude = Magnitude(velocity);
            if (magnitude > 0)
            {
                velocity *= 5f / magnitude;
            }
            else
            {
                velocity = new Vector2(0f, 5f);
            }
            Projectile.NewProjectile(npc.Center, velocity, type, npc.damage, 2f);
        }

        public override void AI()
        {
            aiType = NPCID.Unicorn;
           // DespawnHandler(); // Handles if the NPC should despawn.f

            //Attacking
            countdown = 100;
            countdown = countdown - 100; 
            if (countdown == 0)
            {
              Shoot();
              countdown = 100;
            }
        }
        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }
    }
}
