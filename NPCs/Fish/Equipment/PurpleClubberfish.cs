using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class PurpleClubberfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Clubberfish");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.damage = 48;
            npc.defense = 12;
            npc.lifeMax = 250;
            npc.knockBackResist = 0.85f;

            npc.width = 100;
            npc.height = 44;
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
                Item.NewItem(npc.getRect(), mod.ItemType("CorruptionFishMeat"));
            }

            if (Main.rand.NextFloat() < 0.03f)
            {
                Item.NewItem(npc.getRect(), 2330);      //Purple Clubberfish
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
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/PurpleClubberfish1"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/PurpleClubberfish2"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/PurpleClubberfish3"), 1f);
            }
        }
    }
}