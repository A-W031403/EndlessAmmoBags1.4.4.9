using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessDryRocketPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 0f;
            Item.damage = 40;
            Item.width = 26;
            Item.height = 34;
            Item.knockBack = 4f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Orange;
            Item.ammo = AmmoID.Rocket;
        }
        public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
        {
            if (weapon.type == ItemID.RocketLauncher)
            {
                type = ProjectileID.DryRocket;
            }
            else if (weapon.type == ItemID.GrenadeLauncher)
            {
                type = ProjectileID.DryGrenade;
            }
            else if (weapon.type == ItemID.ProximityMineLauncher)
            {
                type = ProjectileID.DryMine;
            }
            else if (weapon.type == ItemID.Celeb2)
            {
                type = ProjectileID.Celeb2Rocket;
            }
            else if (weapon.type == ItemID.SnowmanCannon)
            {
                type = ProjectileID.DrySnowmanRocket;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DryRocket, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
