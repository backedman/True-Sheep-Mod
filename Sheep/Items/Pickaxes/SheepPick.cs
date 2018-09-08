using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Pickaxes
{
    public class SheepPick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sheep Pickaxe");
            Tooltip.SetDefault("The pickaxe from soft ores of the ground");
        }
        public override void SetDefaults()
        {
            item.damage = 5;
            item.pick = 40;
            item.melee = true;
            item.knockBack = 4;
            item.useTime = 12;
            item.useStyle = 1;
            item.useAnimation = 12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 6;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepBar", 20);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
