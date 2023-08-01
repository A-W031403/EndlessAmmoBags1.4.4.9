using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessCursedPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 5f;
            Item.shoot = ProjectileID.CursedBullet;
            Item.damage = 12;
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.Bullet;
            Item.knockBack = 4f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.rare = ItemRarityID.Blue;
            Item.DamageType = DamageClass.Ranged;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CursedBullet, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
