using FantasyRPG.GameWorldCreator.Models;

namespace FantasyRPG.GameWorldCreator;

public class GameWorldGenerator
    {
        private static Random random = new Random();

        public static WorldMap GenerateWorldMap(int width, int height, List<Biome> biomes)
        {
            WorldMap worldMap = new WorldMap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int elevation = random.Next(0, 200);

                    Biome selectedBiome = SelectBiome(biomes, elevation);

                    worldMap.Map[x, y] = new Tile(selectedBiome.Name, elevation);
                }
            }

            return worldMap;
        }

        private static Biome SelectBiome(List<Biome> biomes, int elevation)
        {
            foreach (var biome in biomes)
            {
                if (elevation >= biome.MinElevation && elevation <= biome.MaxElevation)
                {
                    return biome;
                }
            }

            return biomes[0];
        }

        private static void SetBiomeColor(string biome)
        {
            switch (biome)
            {
                case "Lake":
                    Console.ForegroundColor = ConsoleColor.Blue;  
                    break;
                case "Forest":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;  
                    break;
                case "Desert":
                    Console.ForegroundColor = ConsoleColor.Yellow;  
                    break;
                case "Mountain":
                    Console.ForegroundColor = ConsoleColor.Gray;  
                    break;
                case "Plains":
                    Console.ForegroundColor = ConsoleColor.Green;  
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;  
                    break;
            }
        }

        
        private static void ResetColor()
        {
            Console.ResetColor();
        }

        
        public static void PrintMap(WorldMap worldMap)
        {
            for (int y = 0; y < worldMap.Height; y++)
            {
                for (int x = 0; x < worldMap.Width; x++)
                {
                    var tile = worldMap.Map[x, y];
                    SetBiomeColor(tile.Biome);
                    Console.Write(tile.Biome[0] + " ");  
                    ResetColor();
                }
                Console.WriteLine();  
            }
        }
    }