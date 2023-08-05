using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace EndlessAmmoBags.Content.Ammunition.Pouches
{
    public class EndlessMiniNukeIIPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shootSpeed = 0f;
            Item.damage = 75;
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
                type = ProjectileID.MiniNukeRocketII;
            }
            else if (weapon.type == ItemID.GrenadeLauncher)
            {
                type = ProjectileID.MiniNukeGrenadeII;
            }
            else if (weapon.type == ItemID.ProximityMineLauncher)
            {
                type = ProjectileID.MiniNukeMineII;
            }
            else if (weapon.type == ItemID.Celeb2)
            {
                type = ProjectileID.Celeb2RocketExplosiveLarge;
            }
            else if (weapon.type == ItemID.SnowmanCannon)
            {
                type = ProjectileID.MiniNukeSnowmanRocketII;
            }
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.MiniNukeII, 4000) // AddIngredient takes ItemID, then Quantity
                .AddTile(TileID.WorkBenches) // AddTile takes the TileID
                .Register(); // Register registers the item
        }
    }
}
