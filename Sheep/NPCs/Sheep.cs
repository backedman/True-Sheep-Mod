using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.NPCs
{
    public class Sheep : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sheep");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.width = 38;
            npc.height = 20;
            npc.damage = 0;
            npc.defense = 3;
            npc.lifeMax = 30;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 90f; //money drop
            npc.knockBackResist = 1.0f; //kbr
            npc.aiStyle = 26; //acts like unicorn
            aiType = NPCID.Unicorn; //acts like a unicorn
            animationType = 3;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDaySlime.Chance * 0.2f;
        }
        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("SheepBone"), Main.rand.Next(2, 5));
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Wool"), Main.rand.Next(3, 6));
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(mod.BuffType("WooledUp"), 150, true);
        }
    }
}
