using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items
{
        public class SheepOreSpawner : ModItem
        {
            public override void SetStaticDefaults()
            {
                DisplayName.SetDefault("Sheep Ore Spawner");
                Tooltip.SetDefault("Spawns Sheep Ore");
            }
            public override void SetDefaults()
            {
                item.maxStack = 99;
                item.value = 25;
                item.width = 10;
                item.height = 20;
                item.rare = 1;
                item.consumable = true;
                item.useStyle = 4;
            }
            public override bool CanUseItem(Player player)
            {
            if (World.Sheeporetiles == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            }
            public override bool UseItem(Player player)
            {
               for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 4E-04); k++)
               {
                int x = WorldGen.genRand.Next(0, Main.maxTilesX); // X Coord of the tile
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // Y Coord of the tile
                WorldGen.OreRunner(x, y, (double)WorldGen.genRand.Next(5, 9), WorldGen.genRand.Next(2, 6), (ushort)mod.TileType("SheepOreTile"));     
               }
            return true;
            }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Wool", 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}
