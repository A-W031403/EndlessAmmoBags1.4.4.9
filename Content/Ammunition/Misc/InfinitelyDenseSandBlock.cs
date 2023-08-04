using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Misc
{
    public class InfinitelyDenseSandBlock : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 0f;
            Item.shoot = ProjectileID.SandBallGun;
            Item.damage = -1;
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.Sand;
            Item.knockBack = 0f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Orange;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SandBlock, 10000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
            CreateRecipe()
                .AddIngredient(ItemID.EbonsandBlock, 10000)
                .AddTile(TileID.WorkBenches)
                .Register();
            CreateRecipe()
                .AddIngredient(ItemID.CrimsandBlock, 10000)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
