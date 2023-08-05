using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.ClenSolus
{
    public class EndlessBlueSolutionTank : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Lime;
            Item.DamageType = DamageClass.Ranged;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.Solution;
            Item.shootSpeed = 0f;
            Item.damage = -1;
            Item.knockBack = 0f;
        }

        public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
        {
            if (weapon.type == ItemID.Clentaminator)
            {
                type = ProjectileID.HallowSpray;
            }
            else if (weapon.type == ItemID.Clentaminator2)
            {
                type = ProjectileID.HallowSpray;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BlueSolution, 7500) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
