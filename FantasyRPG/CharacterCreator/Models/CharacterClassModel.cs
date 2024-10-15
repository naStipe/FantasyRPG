namespace FantasyRPG.CharacterCreator.Models;

public class Warrior : Character
{
    public Warrior(string name) : base(name, 150, 50, 100, 60) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Warrior: {Name}, Health: {Health}, Strength: {Strength}, Agility: {Agility}");
    }
}

public class Mage : Character
{
    public Mage(string name) : base(name, 80, 200, 50, 40) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Mage: {Name}, Health: {Health}, Mana: {Mana}, Agility: {Agility}");
    }
}