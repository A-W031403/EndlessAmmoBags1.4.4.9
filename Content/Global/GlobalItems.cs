using EndlessAmmoBags.Content.Ammunition.ModAmmos;
using Microsoft.Xna.Framework;
using System.Security.Cryptography.X509Certificates;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace EndlessAmmoBags.Content.Global
{
    public class GlobalItems : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.TungstenBullet)
            {
                item.shoot = ModContent.ProjectileType<TungstenAmmoProjectile>();
            }

        /*    if (item.type != ItemID.Celeb2)
            {
                return;
            } else
            {
                item.useAmmo = ModContent.ItemType<>();
            }
        */

        }

        public override void AddRecipes()
        {
            Recipe extraDefaultPouchRecipe = Recipe.Create(ItemID.EndlessMusketPouch);
            extraDefaultPouchRecipe.AddIngredient(ItemID.MusketBall, 3996);
            extraDefaultPouchRecipe.AddTile(TileID.WorkBenches);
            extraDefaultPouchRecipe.Register();

            Recipe extraDefaultQuiverRecipe = Recipe.Create(ItemID.EndlessQuiver);
            extraDefaultQuiverRecipe.AddIngredient(ItemID.WoodenArrow, 3996);
            extraDefaultQuiverRecipe.AddTile(TileID.WorkBenches);
            extraDefaultQuiverRecipe.Register();
        }
    }
}
