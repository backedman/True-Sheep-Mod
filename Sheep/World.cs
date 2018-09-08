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

namespace Sheep
{
    public class World : ModWorld
    {
        public static bool downedTutorialBoss = false;
        public static int Sheeporetiles;   
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex != -1)
            {
                tasks.Insert(ShiniesIndex + 1, new PassLegacy("Sheep Mod Ores", delegate (GenerationProgress progress)
                {
                    progress.Message = "Ores Being Developed";

                    for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 4E-04); k++)
                    {
                        WorldGen.TileRunner(
                            WorldGen.genRand.Next(0, Main.maxTilesX), // X Coord of the tile
                            WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY), // Y Coord of the tile
                            (double)WorldGen.genRand.Next(5, 9), // Strength (High = more)
                            WorldGen.genRand.Next(2, 6), // Steps 
                            mod.TileType("SheepOreTile"), // The tile type that will be spawned
                            false, // Should tiles be replaced or added (false for replaced and true for added)
                            0.2f, // Speed X ???
                            0.2f, // Speed Y ???
                            false, // noYChange ??? 
                            true); // Overrides existing tiles
                    }
                }
                ));
            }
        }
        public override void TileCountsAvailable(int[] tileCounts)
        {
            World.Sheeporetiles = tileCounts[mod.TileType("SheepOreTile")];
        }
        public override void Initialize()
        {
            downedTutorialBoss = false;
        }
    }
}
