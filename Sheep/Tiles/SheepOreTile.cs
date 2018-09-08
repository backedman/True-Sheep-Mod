using System.IO;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Microsoft.Xna.Framework.Graphics;


namespace Sheep.Tiles
{
    public class SheepOreTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = false; 
            Main.tileLighted[Type] = false;  //true for block to emit light
            drop = mod.ItemType("SheepOre");
            AddMapEntry(new Color(224, 227, 255));
         /** if (SheepPlayer.HasSheepitem == true)
            {
                minpick = 25;
            }
            else
            {
                minPick = 10000;
            } */ //if sheep player has bone pick, the sheep ore is minable, else it is not.
        }
        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.5f;
            g = 0.5f;
            b = 0.5f;
        }
    }
}
