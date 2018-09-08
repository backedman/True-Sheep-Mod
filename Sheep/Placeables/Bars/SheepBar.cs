using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace Sheep.Placeables.Bars
{
    public class SheepBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bars made from the soft material in the ground");
            DisplayName.SetDefault("Sheep Bar");
        }
        public override void SetDefaults()
        {
            item.height = 24;
            item.width = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.consumable = true;
            item.autoReuse = true;
            item.rare = 2;
            item.value = 1000;
            item.createTile = mod.TileType("SheepBarTile");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepOre", 3);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
}