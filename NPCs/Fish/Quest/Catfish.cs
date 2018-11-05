using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AdvancedTinkering.NPCs.Fish.Quest
{
    public class Catfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Catfish");
            Main.npcFrameCount[npc.type] = 6;
        }

        public override void SetDefaults()
        {
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
            npc.knockBackResist = 0.5f;

            npc.width = 26;
            npc.height = 18;
            npc.npcSlots = 0.5f;
            animationType = 241;
            npc.aiStyle = 16;
            aiType = 55;
            npc.noGravity = true;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = Item.buyPrice(0, 0, 0, 0);

            //banner = npc.type;
            //bannerItem = mod.ItemType("CatfishBanner");

            Main.npcCatchable[npc.type] = true;
            npc.catchItem = 2479;                       //Catfish
        }

        public override void NPCLoot()
        {
            if (Main.rand.NextFloat() < 0.333f)
            {
                Item.NewItem(npc.getRect(), mod.ItemType("NormalFishMeat"));
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            Player player = spawnInfo.player;

            if (spawnInfo.player.ZoneOverworldHeight)
            {
                return SpawnCondition.JungleWater.Chance * 0.1f;
            }
            return 0f;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                //Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/CatfishGore"), 1f);
            }
        }
    }
}