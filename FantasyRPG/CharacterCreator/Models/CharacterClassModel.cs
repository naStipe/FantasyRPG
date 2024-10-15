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

public class Archer : Character
{
    public Archer(string name) : base(name, 100, 75, 70, 90) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Archer: {Name}, Health: {Health}, Agility: {Agility}, Strength: {Strength}");
    }
}