using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.NPCs
{
    public class MutatedSheep : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mutated Sheep");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 48;
            npc.height = 32;
            npc.damage = 40; //this is now a 3 shot (from 5 shot)
            npc.defense = 14;
            npc.lifeMax = 50;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 90f;
            npc.knockBackResist = 0.4f;
            npc.aiStyle = 26;
            aiType = NPCID.Unicorn;
            animationType = 3;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.15f;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SheepBone"), Main.rand.Next(4, 7)); //mob has chance of dropping 4-7 SheepBone
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Wool"), Main.rand.Next(4, 8)); //mob has chance of dropping 4-8 wool
            int random = Main.rand.Next(0, 20); //random is chance for a Bone item to drop
            if (random == 8)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneSword"), Main.rand.Next(0, 1)); //if random is 8, mob has 50% chance of dropping item
            }
            else if (random == 10)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BonePick"), Main.rand.Next(0, 1)); //if random is 10, mob has 50% chance of dropping the item
            }
            else if (random == 15)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneHelmet"), Main.rand.Next(0, 1)); //see above
            }
            else if (random == 12)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneAxe"), Main.rand.Next(0, 1)); //see above
            }
            else if (random == 20)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneGreaves"), Main.rand.Next(0, 1)); //see above
            }
            else if (random == 2)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BoneChestplate"), Main.rand.Next(0, 1)); //see above
            }
        }

            public override void OnHitPlayer(Player target, int damage, bool crit)
            {
                target.AddBuff(mod.BuffType("WooledUp"), 300, true); //if player is hit, add WooledUp debuff for 300 ticks
            }
    }
}
