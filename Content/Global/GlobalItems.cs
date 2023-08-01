using EndlessAmmoBags.Content.Ammunition.ModAmmos;
using Microsoft.Xna.Framework;
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
           
    }
}
