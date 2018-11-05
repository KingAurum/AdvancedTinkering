using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System.Linq;

namespace AdvancedTinkering
{
    public class ATWorld : ModWorld
    {/*
        public static int GoldenBiome = 0;
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (genIndex == -1)
            {
                return;
            }
            tasks.Insert(genIndex + 1, new PassLegacy("Golden Biome", delegate (GenerationProgress progress)
            {
                progress.Message = "Golden Biome Progress";
                for (int i = 0; i < Main.maxTilesX / 1200; i++)       //1200 is how many biomes. the bigger is the number = less biomes
                {
                    int X = WorldGen.genRand.Next(1, Main.maxTilesX - 300);
                    int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - 100, Main.maxTilesY - 200);
                    int TileType = mod.TileType("GoldenDirtBlockTile");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

                    WorldGen.TileRunner(X, Y, 240, WorldGen.genRand.Next(90, 180), TileType, false, 0f, 0f, true, true);  //240 is how big is the biome     90, 180 this changes how random it looks.

                    for (int k = 0; k < 900; k++)                     //750 is the ore spawn rate. the bigger is the number = more ore spawns
                    {
                        int Xo = X + Main.rand.Next(-240, 240);
                        int Yo = Y + Main.rand.Next(-240, 240);
                        if (Main.tile[Xo, Yo].type == mod.TileType("GoldenDirtBlockTile"))   //this is the tile where the ore will spawn
                        {
                            {
                                WorldGen.TileRunner(Xo, Yo, (double)WorldGen.genRand.Next(5, 10), WorldGen.genRand.Next(5, 10), mod.TileType("GoldRockBlockTile"), false, 0f, 0f, false, true);  //   5, 10 is how big is the ore veins.    mod.TileType("GoldenOreTile") is the Golden ore tile,  if you want a vanila ore just do this: TileID.Cobalt, for cobalt spawn
                            }
                        }
                    }

                }

            }));
        }

        public override void TileCountsAvailable(int[] tileCounts)
        {
            GoldenBiome = tileCounts[mod.TileType("GoldenDirtBlockTile")];       //this make the public static int GoldenBiome counts as Goldentileblock
        }
    */}
}