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
        
        // Item creation examples
        ItemFacotry commonItemFactory = new CommonItemFactory();

        Weapon commonWeapon = commonItemFactory.CreateWeapon();

        commonWeapon.DisplayInfo();

        ItemFacotry legendaryItemFactory = new LegendaryItemFactory();

        Weapon legendaryWeapon = legendaryItemFactory.CreateWeapon();

        legendaryWeapon.DisplayInfo();


        // Character actions
        // Get arnold the warrior
        Character arnold = gameWorld.WorldCharacters.First(character => character.Name == "Arnold");

        arnold.PerformAction();

        // Set arnold state to action
        arnold.SetState(new ActionState(new AttackAction()));

        // Perform an action using the default melee attack
        arnold.PerformAction();

        // Set arnold into defending state
        arnold.SetState(new DefendingState());
        arnold.PerformAction();
        
        GameWorldGenerator.PrintMap(gameWorld.WorldMap);
    }
}

