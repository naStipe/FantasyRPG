namespace FantasyRPG.ItemCreator.Models;

public class ItemFactory
{
    public abstract Weapon CreateWeapon();
    public abstract Potion CreatePotion();
    public abstract Armor CreateArmor();
}

