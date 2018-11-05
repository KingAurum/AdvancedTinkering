using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class Swordfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swordfish");
            Main.npcFrameCount[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.damage = 38;
            npc.defense = 2;
            npc.lifeMax = 295;
            npc.knockBackResist = 0.45f;

            npc.width = 140;
            npc.height = 46;
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

            if (Main.rand.NextFloat() < 0.03f)
            {
                Item.NewItem(npc.getRect(), 2332);      //Swordfish
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (NPC.downedBoss1)
            {
                return SpawnCondition.Ocean.Chance * 1.2f;
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