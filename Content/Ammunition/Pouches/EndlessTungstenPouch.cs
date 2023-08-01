using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
using EndlessAmmoBags.Content.Ammunition.ModAmmos;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessTungstenPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 4.5f;
            Item.shoot = ModContent.ProjectileType<TungstenAmmoProjectile>();
            Item.damage = 9;
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.Bullet;
            Item.knockBack = 4f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.White;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TungstenBullet, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
