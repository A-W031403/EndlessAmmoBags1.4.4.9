using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessFallenStarPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shoot = ProjectileID.FallingStar;
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.FallenStar;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Cyan;
            //Item.shootSpeed = Item.shootSpeed * 3;          Maybe a 2nd item with boosted stats? Endless Super Star Pouch or something
            //Item.damage = Item.damage * 3;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FallenStar, 1500) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.CrystalBall) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
