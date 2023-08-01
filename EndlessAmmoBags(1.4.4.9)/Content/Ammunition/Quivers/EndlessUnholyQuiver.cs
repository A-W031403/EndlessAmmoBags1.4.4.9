using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Quivers
{
    public class EndlessUnholyQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 3.4f;
            Item.shoot = ProjectileID.UnholyArrow; //unholy arrow id
            Item.damage = 12;
            Item.width = 32;
            Item.height = 32;
            Item.ammo = AmmoID.Arrow;
            Item.knockBack = 3f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Blue;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.UnholyArrow, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
