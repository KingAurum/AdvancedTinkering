using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class SawtoothShark : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sawtooth Shark");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.damage = 26;
            npc.defense = 1;
            npc.lifeMax = 290;
            npc.knockBackResist = 0.50f;

            npc.width = 160;
            npc.height = 56;
            npc.npcSlots = 0.5f;
            animationType = 65;
            npc.aiStyle = 16;
            aiType = 157;                               //Arapaima
            npc.noGravity = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 4, 0);

            banner = NPCID.Shark;
            bannerItem = 1680;                          //Shark Banner
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("NormalFishMeat"));
            }

            if (Main.rand.NextFloat() < 0.666f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("SharkTooth"));
            }

            if (Main.rand.NextFloat() < 0.98f)
            {
                Item.NewItem(npc.getRect(), 319);       //Shark Fin
            }

            if (Main.rand.NextFloat() < 0.02f)
            {
                Item.NewItem(npc.getRect(), 268);       //Diving Helmet
            }

            if (Main.rand.NextFloat() < 0.03f)
            {
                Item.NewItem(npc.getRect(), 2342);      //Sawtooth Shark
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (NPC.downedBoss1)
            {
                return SpawnCondition.Ocean.Chance * 1.5f;
            }
            return 0f;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SawtoothShark1"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SawtoothShark2"), 1f);
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SawtoothShark3"), 1f);
            }
        }
    }
}