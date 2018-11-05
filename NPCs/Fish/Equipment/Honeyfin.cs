using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class Honeyfin : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Honeyfin");
            Main.npcFrameCount[npc.type] = 6;
        }

        public override void SetDefaults()
        {
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
            npc.knockBackResist = 0.50f;

            npc.width = 28;
            npc.height = 22;
            npc.npcSlots = 0.5f;
            animationType = 58;
            npc.aiStyle = 16;
            aiType = 55;
            npc.noGravity = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 0, 16);

            banner = NPCID.Shark;
            bannerItem = 1680;                          //Shark Banner

            Main.npcCatchable[npc.type] = true;
            npc.catchItem = 2314;                       //Honeyfin
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("HoneyFishMeat"));
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (player.ZoneJungle)
            {
                return SpawnCondition.JungleWater.Chance * 2.0f;
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