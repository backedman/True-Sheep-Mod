using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Placeables.Ore
{
    public class SheepOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sheep Ore");
            Tooltip.SetDefault("The ore of sheep");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.value = 100;
            item.width = 12;
            item.height = 12;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.consumable = true;
            item.useTurn = true;
            item.useStyle = 1;
            item.useTime = 10;
            item.useAnimation = 15;
            item.createTile = mod.TileType("SheepOreTile");
        }

    }
}
