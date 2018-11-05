using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace AdvancedTinkering
{
    public class ATPlayer : ModPlayer
    {
        //------------------------------Accessories------------------------------\\
        public bool AwokenPanic = false;
        public bool AwokenIceBarrier = false;

        //------------------------------Enchantments------------------------------\\
        public bool ConfusedEnchantment = false;
        public bool CursedInfernoEnchantment = false;
        public bool ElectrifiedEnchantment = false;
        public bool FrostburnEnchantment = false;
        public bool IchorEnchantment = false;
        public bool MidasEnchantment = false;
        public bool OnFireEnchantment = false;
        public bool PoisonedEnchantment = false;
        public bool ShadowflameEnchantment = false;
        public bool SlowEnchantment = false;
        public bool VenomEnchantment = false;

        //------------------------------Terra------------------------------\\
        public bool TerraArmor = false;
        public bool TerraWeapon = false;
        public bool TerraBlessing = false;
        public bool TerraCurse = false;

        //------------------------------Ammo Costs------------------------------\\
        public bool ammoCost95 = false;
        public bool ammoCost90 = false;
        public bool ammoCost85 = false;
        public bool ammoCost80 = false;
        public bool ammoCost75 = false;
        public bool ammoCost70 = false;
        public bool ammoCost65 = false;
        public bool ammoCost60 = false;
        public bool ammoCost55 = false;
        public bool ammoCost50 = false;

        //------------------------------Item Costs------------------------------\\
        public bool itemCost95 = false;
        public bool itemCost90 = false;
        public bool itemCost85 = false;
        public bool itemCost80 = false;
        public bool itemCost75 = false;
        public bool itemCost70 = false;
        public bool itemCost65 = false;
        public bool itemCost60 = false;
        public bool itemCost55 = false;
        public bool itemCost50 = false;

        //------------------------------Minions------------------------------\\
        public bool BorealWoodSapling = false;
        public bool DynastyWoodSapling = false;
        public bool EbonWoodSapling = false;
        public bool PalmWoodSapling = false;
        public bool PearlWoodSapling = false;
        public bool PineWoodSapling = false;
        public bool PurityWoodSapling = false;
        public bool RichMahoganyWoodSapling = false;
        public bool ShadeWoodSapling = false;
        public bool SpookyWoodSapling = false;

        public bool Creeper = false;
        public bool Devourer = false;
        public bool ServantSkull = false;
        public bool OtherworldlyFlyB = false;
        public bool OtherworldlyFlyE = false;

        //------------------------------Biomes------------------------------\\
        public bool ZoneGoldenBiome = false;

        public override void ResetEffects()
        {
            //------------------------------Accessories------------------------------\\
            AwokenPanic = false;
            AwokenIceBarrier = false;

            //------------------------------Enchantments------------------------------\\
            ConfusedEnchantment = false;
            CursedInfernoEnchantment = false;
            ElectrifiedEnchantment = false;
            FrostburnEnchantment = false;
            IchorEnchantment = false;
            MidasEnchantment = false;
            OnFireEnchantment = false;
            PoisonedEnchantment = false;
            ShadowflameEnchantment = false;
            SlowEnchantment = false;
            VenomEnchantment = false;

            //------------------------------Terra------------------------------\\
            TerraArmor = false;
            TerraWeapon = false;
            TerraBlessing = false;
            TerraCurse = false;

            //------------------------------Ammo Costs------------------------------\\
            ammoCost95 = false;
            ammoCost90 = false;
            ammoCost85 = false;
            ammoCost80 = false;
            ammoCost75 = false;
            ammoCost70 = false;
            ammoCost65 = false;
            ammoCost60 = false;
            ammoCost55 = false;
            ammoCost50 = false;

            //------------------------------Item Costs------------------------------\\
            itemCost95 = false;
            itemCost90 = false;
            itemCost85 = false;
            itemCost80 = false;
            itemCost75 = false;
            itemCost70 = false;
            itemCost65 = false;
            itemCost60 = false;
            itemCost55 = false;
            itemCost50 = false;

            //------------------------------Minions------------------------------\\
            BorealWoodSapling = false;
            DynastyWoodSapling = false;
            EbonWoodSapling = false;
            PalmWoodSapling = false;
            PearlWoodSapling = false;
            PineWoodSapling = false;
            PurityWoodSapling = false;
            RichMahoganyWoodSapling = false;
            ShadeWoodSapling = false;
            SpookyWoodSapling = false;

            Creeper = false;
            Devourer = false;
            ServantSkull = false;
            OtherworldlyFlyB = false;
            OtherworldlyFlyE = false;
        }
        /*
        public override void UpdateBiomes()
        {
            ZoneGoldenBiome = (ATWorld.GoldenBiome > 50);
        }

        public override bool CustomBiomesMatch(Player other)
        {
            ATPlayer modOther = other.GetModPlayer<ATPlayer>(mod);
            return ZoneGoldenBiome == modOther.ZoneGoldenBiome;
        }

        public override void CopyCustomBiomesTo(Player other)
        {
            ATPlayer modOther = other.GetModPlayer<ATPlayer>(mod);
            modOther.ZoneGoldenBiome = ZoneGoldenBiome;
        }

        public override void SendCustomBiomes(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = ZoneGoldenBiome;
            writer.Write(flags);
        }

        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ZoneGoldenBiome = flags[0];
        }
        */
        public override void OnHitNPCWithProj(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            if (projectile.magic && player.inventory[player.selectedItem].magic)
            {
                if (ConfusedEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(31, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(31, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(31, 60);
                }

                if (CursedInfernoEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(39, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(39, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(39, 60);
                }

                if (ElectrifiedEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(144, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(144, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(144, 60);
                }

                if (FrostburnEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(44, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(44, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(44, 60);
                }

                if (IchorEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(69, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(69, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(69, 60);
                }

                if (MidasEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(72, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(72, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(72, 60);
                }

                if (OnFireEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(24, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(24, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(24, 60);
                }

                if (PoisonedEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(20, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(20, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(20, 60);
                }

                if (ShadowflameEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(153, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(153, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(153, 60);
                }

                if (SlowEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(32, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(32, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(32, 60);
                }

                if (VenomEnchantment)
                {
                    if (Main.rand.NextFloat() < 0.14f)
                        target.AddBuff(70, 180);
                    if (Main.rand.NextFloat() < 0.29f)
                        target.AddBuff(70, 120);
                    if (Main.rand.NextFloat() < 0.57f)
                        target.AddBuff(70, 60);
                }
            }
        }

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (TerraArmor && TerraWeapon)
            {
                if (Main.rand.NextFloat() < 0.33f)
                {
                    target.AddBuff(mod.BuffType("TerraCurse"), 60 * Main.rand.Next(1, 5));
                }
            }
        }

        /*public override void MeleeEffects(Item item, Rectangle hitbox)
        {
            if (ConfusedEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 176);
            }

            if (CursedInfernoEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 75);
            }

            if (ElectrifiedEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 226);
            }

            if (FrostburnEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 180);
            }

            if (IchorEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 228);
            }

            if (MidasEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 169);
            }

            if (OnFireEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
            }

            if (PoisonedEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 46);
            }

            if (ShadowflameEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 179);
            }

            if (SlowEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 199);
            }

            if (VenomEnchantment && item.melee)
            {
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 171);
            }
        }*/

        public virtual void ModifyOnHitByNPC(Player player, NPC npc, int damage, bool crit)
        {
            if (AwokenPanic)
            {
                player.AddBuff(mod.BuffType("AwokenPanic"), 300);
            }
        }

        public virtual void ModifyOnHitByProjectile(Projectile proj, int damage, bool crit)
        {
            if (AwokenPanic)
            {
                player.AddBuff(mod.BuffType("AwokenPanic"), 300);
            }
        }

        public override void UpdateBadLifeRegen()
        {
            if (TerraCurse)
            {
                if (player.lifeRegen >= 0)
                {
                    player.lifeRegen = 0;
                }
                player.lifeRegen -= 15;
                player.lifeRegenTime = 0;
            }
        }
    }
}