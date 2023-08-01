using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Quivers
{
    public class Endless_Venom_Quiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 4.3f;
            Item.shoot = ProjectileID.VenomArrow; //Venom arrow id
            Item.damage = 19;
            Item.width = 32;
            Item.height = 32;
            Item.ammo = AmmoID.Arrow;
            Item.knockBack = 4.2f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Orange;

        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.VenomArrow, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
