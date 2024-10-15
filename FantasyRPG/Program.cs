using FantasyRPG.GameWorldCreator;
using FantasyRPG.GameWorldCreator.Models;

namespace FantasyRPG;

internal class Program
{
    static void Main(string[] args)
    {
        var gameWorld = GameWorld.Instance;

        var biomes = new List<Biome>
        {
            new Biome("Lake", 0, 10),
            new Biome("Desert", 10, 25),
            new Biome("Forest", 25, 100),
            new Biome("Plains", 100, 150),
            new Biome("Mountain", 150, 200)
        };

        gameWorld.InitializeWorld(10, 10, biomes);

        CharacterCreator.CharacterCreator.CharacterFactory warriorFactory = new CharacterCreator.CharacterCreator.WarriorFactory();
        CharacterCreator.CharacterCreator.CharacterFactory mageFactory = new CharacterCreator.CharacterCreator.MageFactory();
        CharacterCreator.CharacterCreator.CharacterFactory archerFactory = new CharacterCreator.CharacterCreator.ArcherFactory();

        gameWorld.AddCharacter(warriorFactory.CreateCharacter("Conan"));
        gameWorld.AddCharacter(mageFactory.CreateCharacter("Merlin"));
        gameWorld.AddCharacter(archerFactory.CreateCharacter("Legolas"));

        CharacterCreator.CharacterCreator.NpcFactory npcFactory = new CharacterCreator.CharacterCreator.NpcFactory();

        gameWorld.AddCharacter(npcFactory.CreateCharacter("Villager"));
        gameWorld.AddCharacter(npcFactory.CreateCharacter("Villager"));

        foreach (var character in gameWorld.WorldCharacters)
        {
            character.DisplayInfo();
        }

        GameWorldGenerator.PrintMap(gameWorld.WorldMap);
    }
}

