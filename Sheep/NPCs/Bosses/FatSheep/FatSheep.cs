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

namespace Sheep.NPCs.Bosses.FatSheep

    //THIS BOSS IS INCOMPLETE BC IM TOO BAD AT CODING AND DON'T KNOW WHAT HALF OF THIS STUFF DOES. 
{

    
        [AutoloadBossHead]
        public class FatSheep : ModNPC
        {
            private Player player;
            private float speed;

            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Frozen Eye");
                Main.npcFrameCount[npc.type] = 3;
            }

            public override void SetDefaults()
            {
                npc.aiStyle = -1; // Will not have any AI from any existing AI styles. 
                npc.lifeMax = 10000; // The Max HP the boss has on Normal
                npc.damage = 20; // The base damage value the boss has on Normal
                npc.defense = 35; // The base defense on Normal
                npc.knockBackResist = 0f; // No knockback
                npc.width = 100;
                npc.height = 100;
                npc.value = 10000;
                npc.npcSlots = 2f; // The higher the number, the more NPC slots this NPC takes.
                npc.boss = true; // Is a boss
                npc.lavaImmune = true; // Not hurt by lava
                npc.noGravity = false; // Not affected by gravity
                npc.noTileCollide = false; // Will not collide with the tiles. 
                npc.HitSound = SoundID.NPCHit1;
                npc.DeathSound = SoundID.NPCDeath1;
                music = MusicID.Boss1;

            }

        public override void AI()
            {
                Target(); // Sets the Player Target

                DespawnHandler(); // Handles if the NPC should despawn.

                                             //Attacking
                npc.ai[1] -= 1f; // Subtracts 1 from the ai.
                if (npc.ai[1] <= 0f)
                {
             //       Shoot();
                }
            }

            private void Target()
            {
                player = Main.player[npc.target]; // This will get the player target.
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

           /* private void Shoot()
            {
                int type = mod.ProjectileType("TutorialBossProjectile");
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
                npc.ai[1] = 200f;
            } **/

            private float Magnitude(Vector2 mag)
            {
                return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
            }

            public override void FindFrame(int frameHeight)
            {
                npc.frameCounter += 1;
                npc.frameCounter %= 20;
                int frame = (int)(npc.frameCounter / 2.0);
                if (frame >= Main.npcFrameCount[npc.type]) frame = 0;
                npc.frame.Y = frame * frameHeight;

                RotateNPCToTarget();
            }

            private void RotateNPCToTarget()
            {
                if (player == null) return;
                Vector2 direction = npc.Center - player.Center;
                float rotation = (float)Math.Atan2(direction.Y, direction.X);
                npc.rotation = rotation + ((float)Math.PI * 0.5f);
            }

            public override void NPCLoot()
            {
                if (Main.expertMode)
                {
                    npc.DropBossBags();
                }
                else
                {
                    if (Main.rand.Next(3) == 0) // For items that you want to have a chance to drop 
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SheepOre"));
                    }
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SheepOre")); // For Items that you want to always drop
                }

                // For settings if the boss has been downed
                World.downedTutorialBoss = true;
            }

            public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
            {
                scale = 1.5f;
                return null;
            }

        }
    }
    

