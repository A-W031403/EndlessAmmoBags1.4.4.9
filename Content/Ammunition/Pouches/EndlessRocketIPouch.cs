using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessRocketIPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 0f;
            Item.shoot = ProjectileID.None;
            Item.damage = 40;
            Item.width = 26;
            Item.height = 34;
            Item.knockBack = 4f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Orange;
            Item.ammo = AmmoID.Rocket;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.RocketI, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
