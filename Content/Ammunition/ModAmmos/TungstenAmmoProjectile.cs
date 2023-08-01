using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using Microsoft.Xna.Framework;
using System;

namespace EndlessAmmoBags.Content.Ammunition.ModAmmos
{
    internal class TungstenAmmoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            ProjectileID.Sets.TrailCacheLength[Projectile.type] = 10;
            ProjectileID.Sets.TrailingMode[Projectile.type] = 0;
        }

        public override void SetDefaults()
        {

            Projectile.width = 8;
            Projectile.height = 8;

            Projectile.aiStyle = 1;

            Projectile.friendly = true;
            Projectile.hostile = false;

            Projectile.penetrate = 1;

            Projectile.timeLeft = 600;

            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;

            Projectile.extraUpdates = 1;

            AIType = ProjectileID.Bullet;
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            Projectile.penetrate--;
            if (Projectile.penetrate <= 0)
            {

                int dust = Dust.NewDust(Projectile.Center, 1, 1, DustID.Tungsten, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust].velocity *= 0.3f;
                Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
                Main.dust[dust].noGravity = false;

                int dust2 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Tungsten, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust2].velocity *= 0.3f;
                Main.dust[dust2].scale = (float)Main.rand.Next(40, 58) * 0.013f;
                Main.dust[dust2].noGravity = false;

                int dust3 = Dust.NewDust(Projectile.Center, 1, 1, DustID.Tungsten, 0f, 0.125f, 0, default(Color), 1f);
                Main.dust[dust3].velocity *= 0.3f;
                Main.dust[dust3].scale = (float)Main.rand.Next(40, 58) * 0.013f;
                Main.dust[dust3].noGravity = false;

                SoundEngine.PlaySound(SoundID.Item10, Projectile.position);

                Projectile.Kill();

                return false;
            }

            return false;
        }
    }
}
