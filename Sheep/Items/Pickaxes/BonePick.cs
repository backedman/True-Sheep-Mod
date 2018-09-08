using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Pickaxes
{
    public class BonePick : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bone Pickaxe");
            Tooltip.SetDefault("The pickaxe from the bones of the fluffiest creature alive");
        }
        public override void SetDefaults()
        {
            item.damage = 2;
            item.pick = 25;
            item.melee = true;
            item.knockBack = 2;
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
            recipe.AddIngredient(null, "SheepBone", 20);
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
        }*/
    }
}
