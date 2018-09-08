using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Sheep.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class SheepGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoes made from the soft material in the ground");
            DisplayName.SetDefault("Sheep Greaves");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.defense = 2;
        }
        /*
        public static int Bonus2
        {
            get
            {
                return Bonus2;
            }
            set
            {
                Bonus2 = 1;
            }
        }
        */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepBar", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
