using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessRocketIIIPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 0f;
            Item.damage = 65;
            Item.width = 26;
            Item.height = 34;
            Item.ammo = AmmoID.Rocket;
            Item.knockBack = 6f;
            Item.value = Item.sellPrice(0, 2, 0, 0);
            Item.DamageType = DamageClass.Ranged;
            Item.rare = ItemRarityID.Orange;
        }

        public override void PickAmmo(Item weapon, Player player, ref int type, ref float speed, ref StatModifier damage, ref float knockback)
        {
            if (weapon.type == ItemID.RocketLauncher)
            {
                type = ProjectileID.RocketIII;
            }
            else if (weapon.type == ItemID.GrenadeLauncher)
            {
                type = ProjectileID.GrenadeIII;
            }
            else if (weapon.type == ItemID.ProximityMineLauncher)
            {
                type = ProjectileID.ProximityMineIII;
            }
            else if (weapon.type == ItemID.Celeb2)
            {
                type = ProjectileID.Celeb2RocketLarge;
            }
            else if (weapon.type == ItemID.SnowmanCannon)
            {
                type = ProjectileID.RocketSnowmanIII;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.RocketIII, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
