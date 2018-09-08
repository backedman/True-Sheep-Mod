using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Axes
{
    public class BoneAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The axe made from the bones of the fluffiest creature alive");
            DisplayName.SetDefault("Bone Axe");
        }
        public override void SetDefaults()
        {
            item.damage = 3;
            item.knockBack = (float)2.5;
            item.axe = 5;
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
            recipe.AddIngredient(null, "SheepBone", 18);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        /*public override void OnHitNPC(Terraria.Player player, NPC target, int damage, float knockBack, bool crit)
        {
            int Bonus = Items.Armor.BoneChestplate.Bonus3 + Items.Armor.BoneGreaves.Bonus2 + Items.Armor.BoneHelmet.Bonus1;
            if (Bonus == 3)
            {
                target.AddBuff(mod.BuffType("WooledUp"), 10);
            }
        } */
    }
}
