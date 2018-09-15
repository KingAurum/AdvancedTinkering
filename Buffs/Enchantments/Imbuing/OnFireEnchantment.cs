using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace AdvancedTinkering.Buffs.Enchantments.Imbuing
{
    public class OnFireEnchantment : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("On Fire Enchantment");
            Description.SetDefault("Melee attacks inflict enemies with On Fire.");
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
            player.buffImmune[mod.BuffType("PoisonedEnchantment")] = true;
            player.buffImmune[mod.BuffType("ShadowflameEnchantment")] = true;
            player.buffImmune[mod.BuffType("SlowEnchantment")] = true;
            player.buffImmune[mod.BuffType("VenomEnchantment")] = true;
            player.GetModPlayer<ATPlayer>(mod).OnFireEnchantment = true;
        }
    }
}
