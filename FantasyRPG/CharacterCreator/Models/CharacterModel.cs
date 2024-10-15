namespace FantasyRPG.CharacterCreator.Models;

public abstract class Character
{
    private static int nextId = 1;

    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int Strength { get; set; }
    public int Agility { get; set; }

    protected Character(string name, int health, int mana, int strength, int agility)
    {
        Id = nextId++;
        Name = name;
        Health = health;
        Mana = mana;
        Strength = strength;
        Agility = agility;
    }

    public abstract void DisplayInfo();
}