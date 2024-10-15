namespace FantasyRPG.GameWorldCreator.Models;

public class GameWorld
{
    
    public class WorldMap
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Tile[,] Map { get; private set; }

        public WorldMap(int width, int height)
        {
            Width = width;
            Height = height;
            Map = new Tile[width, height];
        }
    }
    
    public class Tile
    {
        public string Biome { get; set; }
        public int Elevation { get; set; }

        public Tile(string biome, int elevation)
        {
            Biome = biome;
            Elevation = elevation;
        }
    }
    
    public class Biome
    {
        public string Name { get; set; }
        public int MinElevation { get; set; }
        public int MaxElevation { get; set; }

        public Biome(string name, int minElevation, int maxElevation)
        {
            Name = name;
            MinElevation = minElevation;
            MaxElevation = maxElevation;
        }
    }
    public enum WorldTimeEnum
    {
        Morning,
        Day,
        Afternoon,
        Night
    }
}