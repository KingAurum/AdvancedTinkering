using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedTinkering.NPCs.Critter
{
    public class ChickenItem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chicken");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.noMelee = true;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.UseSound = SoundID.Item1;
            item.width = 22;
            item.height = 24;
            item.noUseGraphic = true;
            item.value = Item.sellPrice(0, 0, 70, 0);
            item.rare = 0;
            item.thrown = true;
            item.makeNPC = (short)mod.NPCType("Chicken");
        }
    }
    public class Chicken : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chicken");
            Main.npcFrameCount[npc.type] = 7;
        }

        public override void SetDefaults()
        {
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
            npc.knockBackResist = 0.5f;

            npc.width = 36;
            npc.height = 36;
            npc.npcSlots = 0.5f;
            animationType = 46;
            npc.aiStyle = 7;
            aiType = 46;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 0, 0);

            //banner = npc.type;
            //bannerItem = mod.ItemType("ChickenBanner");

            Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("ChickenItem");
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("NormalBirdMeat"));
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (!spawnInfo.player.ZoneBeach && !spawnInfo.player.ZoneCorrupt && !spawnInfo.player.ZoneCrimson && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneDungeon && !spawnInfo.player.ZoneGlowshroom && !spawnInfo.player.ZoneHoly && !spawnInfo.player.ZoneJungle && !spawnInfo.player.ZoneMeteor && !spawnInfo.player.ZoneSnow && !spawnInfo.player.ZoneTowerNebula && !spawnInfo.player.ZoneTowerSolar && !spawnInfo.player.ZoneTowerStardust && !spawnInfo.player.ZoneTowerVortex)
            {
                if (spawnInfo.player.ZoneOverworldHeight)
                {
                    return SpawnCondition.WaterCritter.Chance * 0.1f;
                }
            }
            return 0f;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ChickenGore"), 1f);
            }
        }
    }
}