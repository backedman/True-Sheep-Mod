using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Axes
{
    public class SheepAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The axe made from the soft ore underground");
            DisplayName.SetDefault("Sheep Axe");
        }
        public override void SetDefaults()
        {
            item.damage = 7;
            item.knockBack = (float)3;
            item.axe = 8;
            item.crit = 6;
            item.autoReuse = true;
            item.useTime = 13;
            item.useAnimation = 13;
            item.autoReuse = true;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepBar", 18);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
    }
}

