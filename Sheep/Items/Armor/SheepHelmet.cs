using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Sheep.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SheepHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The helmet made from the soft material in the ground");
            DisplayName.SetDefault("Sheep Helmet");
        }
        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.defense = 1;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SheepChestplate") && legs.type == mod.ItemType("SheepGreaves");
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "immunity to wooled up";
            SheepPlayer.sheephalfimmunity = true;
            SheepPlayer.sheeparmored = true;
        }
        /*
        public static int Bonus1
        {
            get
            {
                return Bonus1;
            }
            set
            {
                Bonus1 = 1;
            }
        }
        */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepBar", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}