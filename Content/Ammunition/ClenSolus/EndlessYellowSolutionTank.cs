using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.ClenSolus
{
    public class EndlessYellowSolutionTank : ModItem
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
            Item.width = 10;
            Item.height = 12;
            Item.ammo = AmmoID.Solution;
            Item.shoot = ProjectileID.FairyGlowstick;
            Item.shootSpeed = 0f;
            Item.damage = -1;
            Item.knockBack = 0f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SandSolution, 7500) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
