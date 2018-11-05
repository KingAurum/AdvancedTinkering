using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AdvancedTinkering.NPCs.Fish.Equipment
{
    public class FrostDaggerfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Daggerfish");
            Main.npcFrameCount[npc.type] = 6;
        }

        public override void SetDefaults()
        {
            npc.damage = 34;
            npc.defense = 0;
            npc.lifeMax = 45;
            npc.knockBackResist = 0.05f;

            npc.width = 34;
            npc.height = 22;
            npc.npcSlots = 0.5f;
            animationType = 58;
            npc.aiStyle = 16;
            aiType = 58;                               //Piranha
            npc.noGravity = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 0, 16);

            banner = NPCID.Shark;
            bannerItem = 1680;                          //Shark Banner
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("SnowFishMeat"));
            }

            Item.NewItem(npc.getRect(), 3197);          //Frost Daggerfish
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (player.ZoneSnow)
            {
                return SpawnCondition.WaterCritter.Chance * 1.5f;
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