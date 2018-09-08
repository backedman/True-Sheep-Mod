using Sheep.NPCs;
using Terraria;
using Terraria.ModLoader;

namespace Sheep.Buffs
{
    public class WooledUp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Wooled Up!");
            Description.SetDefault("Your movement is impaired!");
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<SheepGlobalNPC>(mod).WooledUp = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<SheepPlayer>(mod).WooledUp = true;
        }
    }
}
