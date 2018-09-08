using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.NPCs
{
    public class SheepGlobalNPC : GlobalNPC
                
    {
        public bool WooledUp = false;

        public override bool InstancePerEntity
        {
            get
            {
                return true;
            }
        }
        /* public override void AI(NPC npc) 
        {
            if (WooledUp)
            {
                                                Replace with a wooled up thing to npcs
            }
        } */

        public override void ResetEffects(NPC npc)
        {
            WooledUp = false;
      } 
    }

}