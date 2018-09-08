using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Armor
{
        [AutoloadEquip(EquipType.Body)]
        public class SheepChestplate : ModItem
        {
            public override void SetStaticDefaults()
            {
                Tooltip.SetDefault("The Chestplate made from the soft material in the ground");
                DisplayName.SetDefault("Sheep Chestplate");
            }
            public override void SetDefaults()
            {
                item.width = 18;
                item.height = 18;
                item.defense = 3;
            }
            /*
            public static int Bonus3
            {
                get
                {
                    return Bonus3;
                }
                set
                {
                    Bonus3 = 1;
                }
            }
            */
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(null, "SheepBar", 35);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
}
