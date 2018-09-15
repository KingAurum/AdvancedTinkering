using Terraria;
using Terraria.ModLoader;

namespace AdvancedTinkering.Buffs.Awoken
{
	public class AwokenFighter : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Awoken Fighter");
            Description.SetDefault("Increases 55% melee damage, 25% melee critical chance, 15% melee speed and 80% melee knockback.\n" +
                "Increases ranged damage by 50%, and ranged critical strike chance by 35%.\n" +
                "Increases to 60% arrow damage.\n" +
                "Increases magic damage by 55% and magic critical chance by 37%.\n" +
                "Increases the minion damage by 65% and knockback by 15%.\n" +
                "Increases the throwing damage by 25% and throwing critical chance by 25%.\n" + 
                "Allows the holder to absorb 25 % of damage done to teammates while above 25 % health.\n" +
                "Gives a chance to dodge attacks, reduces lava damage, 17% of all damage and 32% while under 50% health.\n" +
                "When damaged, increases the holder speed, length of invincibility and releases hallow stars and bees.\n" +
                "Allows the holder to do attacks that can ignore target defense.\n" +
                "When damaged has a chance to confuse nearby enemies.\n" +
                "Increases the strength of friendly bees.\n" +
                "Summons spores over time that will damage enemies.\n" +
                "Allows the holder to inflict fire with melee attacks.\n" +
                "Increases yoyos range by 5 blocks, allows using two yoyos and counterweights at once.\n" +
                "Allows the holder to zoom with ranged weapons using right click.\n" +
                "20% chance of not consuming arrows.\n" +
                "Allows the holder to automatically use mana potions when needed and restores mana from damage.\n" +
                "Increases maximum mana by 60 and reduces mana usage by 10%.\n" +
                "Increases pick up range for mana stars and boosts mana regeneration.\n" +
                "Allows the holder to summon +2 minions and +5 sentries.\n" +
                "Grants Ammo Box, Ammo Reservation, Archery, Bewitched, Clairvoyance, Mana Regeneration, Magic Power, Sharpened, Star in a Bottle and Summoning buffs.\n");
            Main.debuff[Type] = false;
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
        {
            //add_Paladin_Shield_effect_here
            player.blackBelt = true;
            player.lavaRose = true;
            player.endurance += 0.17f;
            if (player.statLife <= player.statLifeMax2 * 0.5)
            {
                player.iceBarrier = true;
                player.endurance += 0.25f;
            }
            player.GetModPlayer<ATPlayer>(mod).AwokenPanic = true;
            player.panic = true;
            player.longInvince = true;
            player.starCloak = true;
            player.bee = true;
            player.brainOfConfusion = true;
            player.strongBees = true;
            player.SporeSac();
            player.sporeSac = true;

            player.magmaStone = true;
            player.meleeDamage += 0.55f;
            player.meleeCrit += 25;
            player.meleeSpeed += 0.15f;
            player.kbGlove = true;
            player.counterWeight = 556 + Main.rand.Next(6);
            player.yoyoGlove = true;
            player.yoyoString = true;

            player.scope = true;
            player.rangedDamage += 0.50f;
            player.rangedCrit += 35;
            player.arrowDamage += 0.60f;
            player.magicQuiver = true;
            
            player.manaFlower = true;
            player.magicCuffs = true;
            player.magicDamage += 0.80f;
            player.magicCrit += 37;
            player.statManaMax2 += 80;
            player.manaCost -= 0.10f;
            player.manaMagnet = true;
            player.manaRegenDelayBonus += 1;
            player.manaRegenBonus += 27;

            player.maxMinions += 7;
            player.maxTurrets += 8;
            player.minionDamage += 0.78f;
            player.minionKB += 0.30f;
            player.statDefense += 3;
            player.moveSpeed += 0.05f;
            player.statManaMax2 += 20;

            player.thrownDamage += 0.25f;
            player.thrownCrit += 25;


            player.statDefense += 8;        //Ironskin
            player.thorns = 0.3333333f;     //Thorns
            player.endurance += 0.1f;       //Endurance
            player.resistCold = true;       //Warmth
            player.kbBuff = true;   //Titan

            if (player.inventory[player.selectedItem].melee)
            {
                player.armorPenetration = 4;
            }

            player.archery = true;      //Archery
            player.ammoBox = true;      //Ammo Box
            player.ammoPotion = true;   //Ammo Reservation

            player.manaRegenBuff = true;    //Mana Regeneration
        }
	}
}
