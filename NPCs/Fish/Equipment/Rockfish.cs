using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class Rockfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rockfish");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.damage = 48;
            npc.defense = 10;
            npc.lifeMax = 240;
            npc.knockBackResist = 0.80f;

            npc.width = 100;
            npc.height = 40;
            npc.npcSlots = 0.5f;
            animationType = 65;
            npc.aiStyle = 16;
            aiType = 65;                                //Shark
            npc.noGravity = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 2, 0);

            banner = npc.type;
            bannerItem = 1680;                          //Shark Banner
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("UndergroundFishMeat"));
            }

            if (Main.rand.NextFloat() < 0.03f)
            {
                Item.NewItem(npc.getRect(), 2320);      //Rockfish
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (NPC.downedBoss1)
            {
                return SpawnCondition.CavePiranha.Chance * 1.5f;
            }
            return 0f;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Rockfish1"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Rockfish2"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Rockfish3"), 1f);
            }
        }
    }
}