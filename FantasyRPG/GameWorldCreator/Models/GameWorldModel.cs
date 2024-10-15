using FantasyRPG.CharacterCreator.Models;

namespace FantasyRPG.GameWorldCreator.Models;

public class GameWorld
{
    
    private static GameWorld _instance;

    private static readonly object lockObj = new object();

    public WorldMap WorldMap { get; private set; }
    public List<Character> WorldCharacters { get; private set; }
    public WorldTimeEnum TimeOfDay { get; set; }

    private GameWorld()
    {
        WorldCharacters = new List<Character>();
        TimeOfDay = WorldTimeEnum.Morning; 
    }

    public static GameWorld Instance
    {
        get
        {
            lock (lockObj)
            {
                if (_instance == null)
                {
                    _instance = new GameWorld();
                }
                return _instance;
            }
        }
    }
    
    public void InitializeWorld(int width, int height, List<Biome> biomes)
    {
        WorldMap = GameWorldGenerator.GenerateWorldMap(width, height, biomes);
    }
    
    public void AddCharacter(Character character)
    {
        WorldCharacters.Add(character);
    }
}
    
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

