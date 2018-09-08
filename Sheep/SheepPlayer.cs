using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameInput;

namespace Sheep
{
   public class SheepPlayer : ModPlayer
    {
        public bool WooledUp = false;
        public static bool sheepimmunity = false;
        public static bool sheephalfimmunity = false;
        public static bool sheeparmored = false;

        public override void ResetEffects()
        {
            WooledUp = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (WooledUp == true && sheepimmunity == false)
            {
                if (sheephalfimmunity == false)
                {
                    player.moveSpeed = 0.5f;
                    player.maxRunSpeed = 0.1f;
                    player.accRunSpeed = 1.6f;
                    player.jump = 0;
                }
                else if (sheephalfimmunity == true)
                {
                    player.moveSpeed = 0.75f;
                    player.maxRunSpeed = 0.5f;
                    player.accRunSpeed = 2.0f;
                    player.jump = (int)0.5;
                }
            }
        }
        public bool HasSheepitemCheck()
        {
            if (player.HasItem(mod.ItemType("Bone Pickaxe")) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool HasSheepitem
        {
            get
            {
                return HasSheepitem;
            }
        }
    }
}
