using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Placeables
{
    public class Wool : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The coat of the fluffiest creature alive");
            DisplayName.SetDefault("Wool");
        }
        public override void SetDefaults()
        {
            item.height = 12;
            item.width = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.consumable = true;
            item.autoReuse = true;
            item.createTile = mod.TileType("WoolTileBlock");
        }

    }
}
