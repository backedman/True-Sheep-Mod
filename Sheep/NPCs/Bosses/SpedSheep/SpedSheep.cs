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
        Vector2[] playerCenter;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sped Sheep");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 300;
            npc.height = 225;
            npc.damage = 50;
            npc.defense = 10;
            npc.lifeMax = 1500;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 90f;
            npc.knockBackResist = 0.4f;
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
        private float MagnitudeLaser(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }
        private float MagnitudeBody(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }

        private void Move(Vector2 offset)
        {
            speed = 10f; 
            Vector2 moveTo = player.Center + offset; // Gets the point that the npc will be moving to.
            Vector2 move = moveTo - npc.Center;
            float magnitude = MagnitudeBody(move);

            move *= speed / magnitude;
            float turnResistance = 10f; // The larget the number the slower the npc will turn.
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            move *= speed / magnitude;
            /*
             * private void Move(Vector2 offset)
        {
            speed = 10f; // Sets the max speed of the npc.
            Vector2 moveTo = player.Center + offset; // Gets the point that the npc will be moving to.
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if(magnitude > speed)
            {
                move *= speed / magnitude; 
            }
            float turnResistance = 10f; // The larget the number the slower the npc will turn.
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
            if(magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }
*/


            npc.velocity = move;
        }
          private void DespawnHandler()
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
          }
        private void Shoot()
        {
            int type = mod.ProjectileType("SheepLaser");
            Vector2 velocity = new Vector2(player.position.X, player.position.Y-50) - npc.Center; // Get the distance between target and npc.
            float magnitude = MagnitudeLaser(velocity);
            if (magnitude > 0)
            {
                velocity *= 10f / magnitude;
            }
            else
            {
                velocity = new Vector2(0f, 5f);
            }
            Projectile.NewProjectile(npc.Center, velocity, type, npc.damage, 2f);
            npc.ai[1] = 150f;
        }

        public override void AI()
        {
            Target(); // Sets the Player Target

            DespawnHandler(); // Handles if the NPC should despawn.

            //Move(new Vector2(0, -100f)); // Calls the Move Method
            //Attacking
            npc.ai[1] -= 1f; // Subtracts 1 from the ai.
            if (npc.ai[1] <= 0f)
            {
                Shoot();
            }
        }
        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }
    }
}
