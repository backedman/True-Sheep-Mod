using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items
{
    public class SheepBone : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sheep Bone");
            Tooltip.SetDefault("The bone of the fluffiest creature alive");
        }
        public override void SetDefaults()
        {
            item.maxStack = 99;
            item.value = 25;
            item.width = 10;
            item.height = 20;
            item.rare = 1;
        }
    }
}
