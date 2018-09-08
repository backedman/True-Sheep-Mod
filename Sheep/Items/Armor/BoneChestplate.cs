using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class BoneChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Chestplate made from the fluffiest creatures alive");
            DisplayName.SetDefault("Bone Chestplate");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.defense = 2;
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
            recipe.AddIngredient(null, "SheepBone", 25);
            recipe.AddIngredient(null, "Wool", 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
