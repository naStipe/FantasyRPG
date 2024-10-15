namespace FantasyRPG.CharacterCreator.Models;

public class Warrior : Character
{
    public Warrior(string name) : base(name, 150, 50, 100, 60) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Warrior: {Name}, Health: {Health}, Strength: {Strength}, Agility: {Agility}");
    }
}