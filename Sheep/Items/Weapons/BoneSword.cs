using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sheep.Items.Weapons
{
    public class BoneSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bone Sword");
            Tooltip.SetDefault("The Bone Slayer");  //The (English) text shown below your weapon's name
        }

        public override void SetDefaults()
        {
            item.damage = 6;           //The damage of your weapon
            item.melee = true;          //Is your weapon a melee weapon?
            item.width = 32;            //Weapon's texture's width
            item.height = 32;           //Weapon's texture's height
            item.useTime = 15;          //The time span of using the weapon. Remember in terraria, 60 frames is a second.
            item.useAnimation = 15;         //The time span of the using animation of the weapon, suggest set it the same as useTime.
            item.useStyle = 1;          //The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
            item.knockBack = 4;         //The force of knockback of the weapon. Maximum is 20
            item.value = Item.buyPrice(gold: 1);           //The value of the weapon
            item.rare = 1;              //The rarity of the weapon, from -1 to 13
            item.UseSound = SoundID.Item1;      //The sound when the weapon is using
            item.autoReuse = true;          //Whether the weapon can use automatically by pressing mousebutton
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "SheepBone", 15);
            recipe.AddIngredient(ItemID.Wood, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
      /*  public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            int Bonus = Items.Armor.BoneChestplate.Bonus3 + Items.Armor.BoneGreaves.Bonus2 + Items.Armor.BoneHelmet.Bonus1;
            if(Bonus == 3)
            {
                target.AddBuff(mod.BuffType("WooledUp"), 10);
            }
        }
      */
    }
}