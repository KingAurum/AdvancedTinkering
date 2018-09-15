using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Enchantments.Imbuing
{
    public class TomeOfMeleeEnchantments : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Tome of Melee Enchantments");
            Description.SetDefault("Melee attacks inflict enemies with random debuffs.");
            Main.debuff[Type] = false;
            Main.buffNoSave[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffImmune[mod.BuffType("ConfusedEnchantment")] = true;
            player.buffImmune[mod.BuffType("CursedInfernoEnchantment")] = true;
            player.buffImmune[mod.BuffType("ElectrifiedEnchantment")] = true;
            player.buffImmune[mod.BuffType("FrostburnEnchantment")] = true;
            player.buffImmune[mod.BuffType("IchorEnchantment")] = true;
            player.buffImmune[mod.BuffType("MidasEnchantment")] = true;
            player.buffImmune[mod.BuffType("OnFireEnchantment")] = true;
            player.buffImmune[mod.BuffType("PoisonedEnchantment")] = true;
            player.buffImmune[mod.BuffType("ShadowflameEnchantment")] = true;
            player.buffImmune[mod.BuffType("SlowEnchantment")] = true;
            player.buffImmune[mod.BuffType("VenomEnchantment")] = true;

            player.GetModPlayer<ATPlayer>(mod).ConfusedEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).CursedInfernoEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).ElectrifiedEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).FrostburnEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).IchorEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).MidasEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).OnFireEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).PoisonedEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).ShadowflameEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).SlowEnchantment = true;
            player.GetModPlayer<ATPlayer>(mod).VenomEnchantment = true;
        }
    }
}